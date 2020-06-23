using CocoChicApp.Contract.DTO.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Business.Interfaces
{
    public interface IEmployeeDetailService
    {
        List<EmployeeListResponse> GetEmployeeList(int designationId, int branchId);
    }
}
