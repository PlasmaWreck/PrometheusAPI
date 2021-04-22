using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Auth : ControllerBase
    {
        private readonly authService _dataFromLogin;

        public Auth(authService dataFromLogin)
        {
            _dataFromLogin = dataFromLogin;
        }








        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] Login user)
        {
            if(user.Email == "User"  && user.Password == "justapassword")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5000",
                    audience: "http://localhost:5000",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddDays(5),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenString });
            }
            return Unauthorized();

        }

        [HttpGet]
        public IEnumerable<Login> GetAccountList()
        {
            return _dataFromLogin.GetAccountList();
        }

        [HttpPost("GetAccount")]
        public IActionResult CheckAccount([FromBody] Login user)
        {
            var x = _dataFromLogin.CheckAccount(user.Email);
            if(x)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5000",
                    audience: "http://localhost:5000",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddDays(5),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenString });
            }
            return Unauthorized();
        }

    }


}