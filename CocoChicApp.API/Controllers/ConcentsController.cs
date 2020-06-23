using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CocoChicApp.Business.Interfaces;
using CocoChicApp.Contract.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CocoChicApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConcentsController : CocoAppBaseController
    {
        private readonly IConsentFormDailyService _consentFormDailyService;
        private readonly IConsentFormInitService _consentFormInitService;

        public ConcentsController(
            IHttpContextAccessor httpContextAccessor,
            IConsentFormDailyService consentFormDailyService,
            IConsentFormInitService consentFormInitService) : base(httpContextAccessor)
        {
            this._consentFormDailyService = consentFormDailyService;
            this._consentFormInitService = consentFormInitService;
        }

        [HttpPost("daily-consent")]
        public IActionResult SaveDailyConsent([FromBody]ConsentFormDailyDTO concentForm)
        {
            return Ok(_consentFormDailyService.SaveDailyConcentForm(concentForm, UserId));
        }

        [HttpPost("init-consent")]
        public IActionResult SaveInitConsent([FromBody]ConsentFormInitiDTO consentForm)
        {
            return Ok(_consentFormInitService.SaveConsentInitForm(consentForm, UserId));
        }

    }
}