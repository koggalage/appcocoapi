using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblMastLeaveType
    {
        public TblMastLeaveType()
        {
            TblEmployeeLeave = new HashSet<TblEmployeeLeave>();
        }

        public int LeaveTypeId { get; set; }
        public string Type { get; set; }
        public int AllowDate { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<TblEmployeeLeave> TblEmployeeLeave { get; set; }
    }
}
