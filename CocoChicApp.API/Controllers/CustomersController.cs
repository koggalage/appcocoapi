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
    public class CustomersController : CocoAppBaseController
    {
        private readonly ICustomerService _customerService;

        public CustomersController(IHttpContextAccessor httpContextAccessor,
                                   ICustomerService customerService) : base(httpContextAccessor)
        {
            _customerService = customerService;
        }

        [HttpGet("list")]
        [ProducesResponseType(typeof(CustomerDTO), (int)HttpStatusCode.OK)]
        public IActionResult GetAllCustomer()
        {

            return Ok(_customerService.GetAllCustomers());
        }

        [HttpPost("search")]
        public IActionResult SearchCustomer([FromBody]CustomerSearchRequest request)
        {
            return Ok(_customerService.SearchCustomer(request));
        }

        [HttpPost("register")]
        public IActionResult Post([FromBody]CustomerDTO customer)
        {
            try
            {
                return Ok(_customerService.SaveCustomer(customer, UserId, BranchId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public IActionResult UpdateCustomer([FromBody]CustomerDTO customer)
        {
            try
            {
                return Ok(_customerService.UpdateCustomer(customer));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("check")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public IActionResult GetCustomerIdExistency([FromQuery] string customerId)
        {
            return Ok(_customerService.GetCustomerIdExistency(customerId));
        }



    }
}