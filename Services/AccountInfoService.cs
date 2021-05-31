using System.Collections.Generic;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using System.Linq;

namespace PrometheusAPI.Services
{
    public class AccountInfoService
    {
        private readonly DataContext _context;

        public AccountInfoService(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Login> GetAccountList()
        {
            return _context.Users;
        }
        
        public bool AddUsersInfo(Login User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
            return true;
        }
    }
}