using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Contract.DTO.UI
{
    public class EmployeeListResponse
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string SignatureURL { get; set; }
    }
}
