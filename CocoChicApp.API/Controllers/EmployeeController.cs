using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CocoChicApp.Business.Interfaces;
using CocoChicApp.Contract.DTO.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CocoChicApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : CocoAppBaseController
    {
        private readonly IEmployeeDetailService _employeeDetailService;
        private readonly IUserInfoService _userInfoService;

        public EmployeeController(IHttpContextAccessor httpContextAccessor,
                                   IEmployeeDetailService employeeDetailService,
                                   IUserInfoService userInfoService) : base(httpContextAccessor)
        {
            _employeeDetailService = employeeDetailService;
            _userInfoService = userInfoService;
        }

        [HttpGet("emplist")]
        [ProducesResponseType(typeof(List<EmployeeListResponse>), (int)HttpStatusCode.OK)]
        public IActionResult GetEmployeeList(int designationId)
        {

            return Ok(_employeeDetailService.GetEmployeeList(designationId, BranchId));
        }

        [HttpGet("userlist")]
        [ProducesResponseType(typeof(List<EmployeeListResponse>), (int)HttpStatusCode.OK)]
        public IActionResult GetUserList(string designation)
        {

            return Ok(_userInfoService.GetUserList(designation, BranchId));
        }

    }
}