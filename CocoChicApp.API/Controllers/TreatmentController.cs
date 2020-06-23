using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CocoChicApp.Business.Interfaces;
using CocoChicApp.Contract.DTO;
using CocoChicApp.Contract.DTO.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CocoChicApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentController : ControllerBase
    {
        private readonly ITreatmentDailyUpdateService _treatmentDailyUpdateService;

        public TreatmentController(ITreatmentDailyUpdateService treatmentDailyUpdateService)
        {
            _treatmentDailyUpdateService = treatmentDailyUpdateService;
        }

        [HttpPost("save")]
        public IActionResult Post([FromBody]TreatmentDailyUpdateDTO dailyUpdates)
        {
            return Ok(_treatmentDailyUpdateService.SaveTreatmentDailyUpdate(dailyUpdates));
        }

        [HttpGet("{history}")]
        [ProducesResponseType(typeof(TreatmentDailyUpdateDTO), (int)HttpStatusCode.OK)]
        public IActionResult GetAllAcrmTreatmentUpdatesr([FromQuery] string customerId)
        {
            return Ok(_treatmentDailyUpdateService.GetTreatmentDailyUpdates(customerId));
        }

        [HttpGet("filter")]
        [ProducesResponseType(typeof(TreatmentDailyUpdateDTO), (int)HttpStatusCode.OK)]
        public IActionResult GetDailyUpdateByDate([FromQuery] int tduid)
        {
            return Ok(_treatmentDailyUpdateService.GetDailyUpdateByDate(tduid));
        }

        [HttpGet("dates")]
        [ProducesResponseType(typeof(List<DailyUpdatesByCustomerResponse>), (int)HttpStatusCode.OK)]
        public IActionResult GetTreatmentDatesByCustomer([FromQuery] string customerId)
        {
            return Ok(_treatmentDailyUpdateService.GetTreatmentDatesByCustomer(customerId));
        }

        [HttpPost("{error}")]
        public void TempError([FromBody]TreatmentDailyUpdateDTO dailyUpdates)
        {
            var er = dailyUpdates.CustomerId;
        }
    }
}