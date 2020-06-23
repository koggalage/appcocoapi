using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblBranch
    {
        public TblBranch()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblMastDepartment = new HashSet<TblMastDepartment>();
            TblMastDesignation = new HashSet<TblMastDesignation>();
            TblMastTreatmentType = new HashSet<TblMastTreatmentType>();
        }

        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tp1 { get; set; }
        public string Tp2 { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public int CompanyId { get; set; }

        public virtual TblCompany Company { get; set; }
        public virtual ICollection<TblCustomer> TblCustomer { get; set; }
        public virtual ICollection<TblMastDepartment> TblMastDepartment { get; set; }
        public virtual ICollection<TblMastDesignation> TblMastDesignation { get; set; }
        public virtual ICollection<TblMastTreatmentType> TblMastTreatmentType { get; set; }
    }
}
