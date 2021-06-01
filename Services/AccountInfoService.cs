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

        public bool UpdateSavedBuild(SavedBuild inputObj)
        {
            var returnable = false;
            if(inputObj.Id == 0)
            {
                _context.Add(new SavedBuild
                {
                    Id = 0,
                    CaseId = inputObj.CaseId,
                    LoginId = inputObj.LoginId,
                    CoolerId = inputObj.CoolerId,
                    MemoryId = inputObj.MemoryId,
                    HardDriveId = inputObj.HardDriveId,
                    ProcessorId = inputObj.ProcessorId,
                    MotherBoardId = inputObj.MotherBoardId,
                    PowerSupplyId = inputObj.PowerSupplyId,
                    GraphicsCardId = inputObj.GraphicsCardId,
                });
                returnable = true;
            }else
            {
                _context.Update(inputObj);
                returnable = false;
            }
            _context.SaveChanges();
            return returnable;

        }
    }
}