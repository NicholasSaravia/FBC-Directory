using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using FBC.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FBC.API.Controllers
{
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IUserService _userService;

        public TokenController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> LogIn(LoginModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var authenticated = await _userService.AuthenticateUser(model.Email, model.Password);
            if (authenticated)
            {
                // generate jwt token
                //var token = await _userService.GenerateToken();
                return Ok();
            }

            return Unauthorized();
        }

        [HttpPost]
        public async Task<IActionResult> Secret(Secret secret)
        {
            var isAllowedAccess = await _userService.TestSecret(secret.password);
            if (isAllowedAccess)
                return Ok();

            return Unauthorized();
        }
        
    }

    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class Secret
    {
        public string password { get; set; }
    }
}
