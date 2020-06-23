﻿using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblEmployeeDeduction
    {
        public int Edid { get; set; }
        public int Empno { get; set; }
        public int DeductionId { get; set; }
        public decimal? DeductionValue { get; set; }
        public int MonthId { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual TblMastDeduction Deduction { get; set; }
        public virtual TblEmployeeDetail EmpnoNavigation { get; set; }
    }
}
