using CocoChicApp.Business.Interfaces;
using CocoChicApp.Contract.DTO.UI;
using CocoChicApp.EF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocoChicApp.Business.Services
{
    public class EmployeeDetailService : IEmployeeDetailService
    {

        private readonly IEmployeeDetailRepository _employeeDetailRepository;

        public EmployeeDetailService(IEmployeeDetailRepository employeeDetailRepository)
        {
            _employeeDetailRepository = employeeDetailRepository;
        }

        public List<EmployeeListResponse> GetEmployeeList(int designationId, int branchId)
        {
            return _employeeDetailRepository.All.Where(x => x.DesignationId == designationId 
                                                         && x.BranchId == branchId 
                                                         && x.IsDeleted == false 
                                                         && x.DeletedBy == null 
                                                         && x.DeletedDate == null)
                .Select(x => new EmployeeListResponse { EmpNo = x.Empno, EmpName = x.Name, SignatureURL = x.SignatureURL })
                .ToList();
        }
    }
}
