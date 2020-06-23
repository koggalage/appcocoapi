using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CocoChicApp.API.Models;
using CocoChicApp.API.Services.Interfaces;
using CocoChicApp.Business.Interfaces;
using CocoChicApp.Contract.DTO.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CocoChicApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;
        private readonly IUserService _userService;

        public LoginController(IUserInfoService userInfoService,
            IUserService userService)
        {
            _userInfoService = userInfoService;
            _userService = userService;
        }

        [HttpPost("signin")]
        [ProducesResponseType(typeof(LoginReponse), (int)HttpStatusCode.OK)]
        public IActionResult SignIn([FromBody]LoginRequest request)
        {
            return Ok(_userInfoService.Login(request));
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

    }
}