using CocoChicApp.Business.Interfaces;
using CocoChicApp.Contract.DTO;
using CocoChicApp.EF.Repositories.Interfaces;
using CocoChicApp.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocoChicApp.Business.Services
{
    public class ConsentFormDailyService : IConsentFormDailyService
    {
        private readonly IConsentFormDailyRepository _consentFormDailyRepository;
        private readonly ICustomerRepository _customerRepository;

        public ConsentFormDailyService(IConsentFormDailyRepository consentFormDailyRepository,
                                       ICustomerRepository customerRepository)
        {
            _consentFormDailyRepository = consentFormDailyRepository;
            _customerRepository = customerRepository;
        }

        public bool SaveDailyConcentForm(ConsentFormDailyDTO concentForm, int userId)
        {
            try
            {
                concentForm.ConsentBy = userId;
                _consentFormDailyRepository.Add(DomainDTOMapper.ToConcentFormDailyDomain(concentForm));
                _consentFormDailyRepository.SaveChanges();
                
                if (!String.IsNullOrEmpty(concentForm.NIC))
                {
                    UpdateCustomer(concentForm.CustomerId, concentForm.NIC);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        private void UpdateCustomer(string customerId, string nic)
        {

            try
            {
                var customer = _customerRepository.FirstOrDefault(x => x.CustomerId == customerId);
                customer.NIC = nic;
                _customerRepository.SaveChanges();
            }
            catch (Exception ex)
            {
            }
            
        }
    }
}
