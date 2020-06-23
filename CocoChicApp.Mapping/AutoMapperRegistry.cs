using AutoMapper;
using CocoChicApp.Contract.DTO;
using CocoChicApp.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Mapping
{
    public class AutoMapperRegistry
    {
        public static void CreateMappings()
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    CreateMappings(cfg);
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void CreateMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CustomerDTO, TblCustomer>()
              .ForMember(c => c.Branch, m => m.Ignore())
              //.ForMember(c => c.CustomerId, m => m.MapFrom(c => c.CustomerId))
              .ForMember(c => c.TblCustomerGiftVoucher, m => m.Ignore())
              .ForMember(c => c.TblCustomerInvoiceHeader, m => m.Ignore())
              .ForMember(c => c.TblCustomerSchedule, m => m.Ignore());

            //cfg.CreateMap<TblCustomer, CustomerDTO>()
            //  .ForMember(c => c.CustomerId, m => m.MapFrom(c => c.CustomerId));

            cfg.CreateMap<Tbl_ConsentFormDaily, ConsentFormDailyDTO>()
              .ForMember(c => c.NIC, m => m.Ignore());
            
            cfg.CreateMap<Tbl_TreatmentDailyUpdate, TreatmentDailyUpdateDTO>()
              .ForMember(c => c.TreatmentImageURLs, m => m.Ignore());

            cfg.CreateMap<TreatmentDailyUpdateDTO, Tbl_TreatmentDailyUpdate>()
              .ForMember(c => c.TreatmentDailyUpdatePhotos, m => m.Ignore());
        }
    }
}
