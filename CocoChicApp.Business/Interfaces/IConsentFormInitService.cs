using CocoChicApp.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Business.Interfaces
{
    public interface IConsentFormInitService
    {
        bool SaveConsentInitForm(ConsentFormInitiDTO consent, int userId);
    }
}
