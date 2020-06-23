using CocoChicApp.Contract.DTO;
using CocoChicApp.Contract.DTO.UI;
using CocoChicApp.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Mapping
{
    public static class DomainDTOMapper
    {
        public static LoginReponse ToLoginReponseDTOs(TblUser userInfo)
        {
            return AutoMapper.Mapper.Map<TblUser, LoginReponse>(userInfo);
        }

        public static List<CustomerDTO> ToCustomerDTOs(List<TblCustomer> customers)
        {
            return AutoMapper.Mapper.Map<List<TblCustomer>, List<CustomerDTO>>(customers);
        }

        public static TblCustomer ToCustomerDomain(CustomerDTO customerDto)
        {
            return AutoMapper.Mapper.Map<CustomerDTO, TblCustomer>(customerDto);
        }

        public static Tbl_ConsentFormDaily ToConcentFormDailyDomain(ConsentFormDailyDTO concentDaily)
        {
            return AutoMapper.Mapper.Map<ConsentFormDailyDTO, Tbl_ConsentFormDaily>(concentDaily);
        }

        public static Tbl_ConsentFormIniti ToConsentFormInitiDomain(ConsentFormInitiDTO concentInit)
        {
            return AutoMapper.Mapper.Map<ConsentFormInitiDTO, Tbl_ConsentFormIniti>(concentInit);
        }

        public static Tbl_TreatmentDailyUpdate ToTreatmentDailyUpdateDomain(TreatmentDailyUpdateDTO dailyUpdateDto)
        {
            return AutoMapper.Mapper.Map<TreatmentDailyUpdateDTO, Tbl_TreatmentDailyUpdate>(dailyUpdateDto);
        }

        public static List<TreatmentDailyUpdateDTO> ToTreatmentDailyUpdateDTOs(List<Tbl_TreatmentDailyUpdate> dailyUpdates)
        {
            return AutoMapper.Mapper.Map<List<Tbl_TreatmentDailyUpdate>, List<TreatmentDailyUpdateDTO>>(dailyUpdates);
        }

        public static TreatmentDailyUpdateDTO ToTreatmentDailyUpdateDTO(Tbl_TreatmentDailyUpdate dailyUpdates)
        {
            return AutoMapper.Mapper.Map<Tbl_TreatmentDailyUpdate, TreatmentDailyUpdateDTO>(dailyUpdates);
        }

    }
}
