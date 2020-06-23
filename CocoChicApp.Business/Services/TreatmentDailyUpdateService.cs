using CocoChicApp.Business.Interfaces;
using CocoChicApp.Business.Util;
using CocoChicApp.Contract.DTO;
using CocoChicApp.Contract.DTO.UI;
using CocoChicApp.EF.Models;
using CocoChicApp.EF.Repositories.Interfaces;
using CocoChicApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocoChicApp.Business.Services
{
    public class TreatmentDailyUpdateService : ITreatmentDailyUpdateService
    {
        private readonly ITreatmentDailyUpdateRepository _treatmentDailyUpdateRepository;
        private readonly ITreatmentDailyUpdatePhotosRepository _treatmentDailyUpdatePhotosRepository;

        public TreatmentDailyUpdateService(ITreatmentDailyUpdateRepository treatmentDailyUpdateRepository,
                                           ITreatmentDailyUpdatePhotosRepository treatmentDailyUpdatePhotosRepository)
        {
            _treatmentDailyUpdateRepository = treatmentDailyUpdateRepository;
            _treatmentDailyUpdatePhotosRepository = treatmentDailyUpdatePhotosRepository;
        }

        public bool SaveTreatmentDailyUpdate(TreatmentDailyUpdateDTO dailyUpdate)
        {
            try
            {
                _treatmentDailyUpdateRepository.Add(DomainDTOMapper.ToTreatmentDailyUpdateDomain(dailyUpdate));
                _treatmentDailyUpdateRepository.SaveChanges();

                var lastDailyUpdate = _treatmentDailyUpdateRepository.All.OrderByDescending(x => x.Date).FirstOrDefault();

                if (dailyUpdate?.TreatmentImageURLs != null)
                {
                    foreach (var url in dailyUpdate.TreatmentImageURLs)
                    {
                        var imageName = string.Format(@"{0}", Guid.NewGuid());

                        ImageConverter.SaveImage(url, imageName);

                        Tbl_TreatmentDailyUpdatePhotos model = new Tbl_TreatmentDailyUpdatePhotos()
                        {
                            Tduid = lastDailyUpdate.Tduid,
                            CustomerId = lastDailyUpdate.CustomerId,
                            FileName = imageName
                        };

                        _treatmentDailyUpdatePhotosRepository.Add(model);
                        _treatmentDailyUpdatePhotosRepository.SaveChanges();
                    }
                }


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TreatmentDailyUpdateDTO> GetTreatmentDailyUpdates(string customerId)
        {
            return DomainDTOMapper.ToTreatmentDailyUpdateDTOs(_treatmentDailyUpdateRepository.Where(x => x.CustomerId == customerId).ToList());
        }

        public List<DailyUpdatesByCustomerResponse> GetTreatmentDatesByCustomer(string customerId)
        {
            var response = new List<DailyUpdatesByCustomerResponse>();

            var updates = _treatmentDailyUpdateRepository.All.Where(x => x.CustomerId == customerId).ToList();

            foreach (var update in updates)
            {
                DailyUpdatesByCustomerResponse dailyUpdatesByCustomerResponse = new DailyUpdatesByCustomerResponse();

                dailyUpdatesByCustomerResponse.Date = update.Date;
                dailyUpdatesByCustomerResponse.Tduid = update.Tduid;
                dailyUpdatesByCustomerResponse.DoctorAppointmentId = update.DoctorAppointmentId;
                dailyUpdatesByCustomerResponse.DoctorNote = update.DoctorNote;

                response.Add(dailyUpdatesByCustomerResponse);
            }

            return response;
        }

        public TreatmentDailyUpdateDTO GetDailyUpdateByDate(int tduid)
        {
            TreatmentDailyUpdateDTO response = new TreatmentDailyUpdateDTO();

            response = DomainDTOMapper.ToTreatmentDailyUpdateDTO(_treatmentDailyUpdateRepository.FirstOrDefault(x => x.Tduid == tduid));

            response.TreatmentImageURLs = _treatmentDailyUpdatePhotosRepository.All.Where(p => p.Tduid == tduid && p.CustomerId == response.CustomerId).Select(p => p.FileName).ToList();

            return response;

        }
    }

}
