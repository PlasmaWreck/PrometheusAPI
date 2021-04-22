using System.Collections.Generic;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;
using System.Linq;


namespace PrometheusAPI.Services
{
    public class authService
    {
        public List<Login> AccountList = new List<Login>(){
            new Login() { Id = 1, Email = "John", Password="Password" } ,
            new Login() { Id = 2, Email = "Steve",Password="Password",  } ,
            new Login() { Id = 3, Email = "Bill", Password="Password", } ,
            new Login() { Id = 4, Email = "Ram" , Password="Password" } ,
            new Login() { Id = 5, Email = "Ron" , Password="Password" }
        };
        
         public IEnumerable<Login> GetAccountList()
        {
            return AccountList;
        }


        public bool CheckAccount(string Email)
        {
            return  AccountList.Where(Account => Account.Email == Email).Any();
        }

    }

    
}