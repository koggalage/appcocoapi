using CocoChicApp.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Business.Interfaces
{
    public interface IConsentFormDailyService
    {
        bool SaveDailyConcentForm(ConsentFormDailyDTO concentForm, int userId);
    }
}
