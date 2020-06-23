using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblEmployeeLeave
    {
        public int EmployeeLeaveId { get; set; }
        public int Empno { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Remark { get; set; }
        public bool IsNope { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual TblEmployeeDetail EmpnoNavigation { get; set; }
        public virtual TblMastLeaveType LeaveType { get; set; }
    }
}
