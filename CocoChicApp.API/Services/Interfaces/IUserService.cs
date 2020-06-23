using CocoChicApp.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CocoChicApp.API.Services.Interfaces
{
    public interface IUserService
    {
        TblUser Authenticate(string username, string password);
        // IEnumerable<User> GetAll();
        // User GetById(int id);
        TblUser Create(TblUser user, string password);
    }
}
