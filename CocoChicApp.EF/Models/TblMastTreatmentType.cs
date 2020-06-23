using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblMastTreatmentType
    {
        public TblMastTreatmentType()
        {
            TblCustomerGiftVoucher = new HashSet<TblCustomerGiftVoucher>();
            TblCustomerInvoiceTreatment = new HashSet<TblCustomerInvoiceTreatment>();
            TblCustomerScheduleTreatment = new HashSet<TblCustomerScheduleTreatment>();
        }

        public int Ttid { get; set; }
        public string Ttname { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int Duration { get; set; }
        public int DepartmentId { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string ColorCode { get; set; }

        public virtual TblBranch Branch { get; set; }
        public virtual TblMastDepartment Department { get; set; }
        public virtual ICollection<TblCustomerGiftVoucher> TblCustomerGiftVoucher { get; set; }
        public virtual ICollection<TblCustomerInvoiceTreatment> TblCustomerInvoiceTreatment { get; set; }
        public virtual ICollection<TblCustomerScheduleTreatment> TblCustomerScheduleTreatment { get; set; }
    }
}
