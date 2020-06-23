using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblEmployeeAllowances
    {
        public int Eaid { get; set; }
        public int Empno { get; set; }
        public int AllowanceId { get; set; }
        public decimal AllowanceValue { get; set; }
        public int MonthId { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual TblMastAllowances Allowance { get; set; }
        public virtual TblEmployeeDetail EmpnoNavigation { get; set; }
    }
}
