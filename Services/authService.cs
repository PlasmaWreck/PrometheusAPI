using System.Collections.Generic;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;
using System.Linq;


namespace PrometheusAPI.Services
{
    public class authService
    {
        private readonly DataContext _context;

        public authService(DataContext context)
        {
            _context = context;
        }

        public List<Login> AccountList = new List<Login>(){
            new Login() { Id = 1, Email = "John", Password="blah" } ,
            new Login() { Id = 2, Email = "Steve",Password="Password",  } ,
            new Login() { Id = 3, Email = "Bill", Password="thing", } ,
            new Login() { Id = 4, Email = "Ram" , Password="chacha" } ,
            new Login() { Id = 5, Email = "Ron" , Password="realSmooth" }
        };
        
        


        public bool CheckAccount(string Email, string Password)
        {
            return  _context.Users.Where(Account => Account.Email == Email && Account.Password == Password).Any();
        }

        

        

    }

    
}