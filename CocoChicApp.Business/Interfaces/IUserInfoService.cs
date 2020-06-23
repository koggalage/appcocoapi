using CocoChicApp.Contract.DTO.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Business.Interfaces
{
    public interface IUserInfoService
    {
        LoginReponse Login(LoginRequest request);

        List<EmployeeListResponse> GetUserList(string designation, int branchId);
    }
}
