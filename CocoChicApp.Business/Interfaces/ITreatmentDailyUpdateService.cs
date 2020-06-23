using CocoChicApp.Contract.DTO;
using CocoChicApp.Contract.DTO.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Business.Interfaces
{
    public interface ITreatmentDailyUpdateService
    {
        bool SaveTreatmentDailyUpdate(TreatmentDailyUpdateDTO dailyUpdate);

        List<TreatmentDailyUpdateDTO> GetTreatmentDailyUpdates(string customerId);

        TreatmentDailyUpdateDTO GetDailyUpdateByDate(int tduid);

        List<DailyUpdatesByCustomerResponse> GetTreatmentDatesByCustomer(string customerId);
    }
}
