

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountInfo
    {
        private readonly authService _dataFromLogin;
        private readonly AccountInfoService _dataFromAccountInfo;

        public AccountInfo(authService dataFromLogin, AccountInfoService dataFromAccountInfo)
        {
            _dataFromLogin = dataFromLogin;
            _dataFromAccountInfo = dataFromAccountInfo;
        }


        [HttpPost("SignUp")]
        public bool AddUserInfo(Login user)
        {
            if (!_dataFromLogin.CheckAccount(user.Email, user.Password))
            {
                return _dataFromAccountInfo.AddUsersInfo(user);
            }
            else
            {
                return false;
            }
        }

        [HttpGet]
        public IEnumerable<Login> GetAccountList()
        {
            return _dataFromAccountInfo.GetAccountList();
        }

        [HttpPost("savedbuild")]
        public bool UpdateSavedBuild([FromBody] SavedBuild inputObj)
            => _dataFromAccountInfo.UpdateSavedBuild(inputObj);
    }
}