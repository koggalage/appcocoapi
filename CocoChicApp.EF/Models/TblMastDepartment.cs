using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblMastDepartment
    {
        public TblMastDepartment()
        {
            TblCustomerGiftVoucher = new HashSet<TblCustomerGiftVoucher>();
            TblCustomerInvoiceHeader = new HashSet<TblCustomerInvoiceHeader>();
            TblCustomerSchedule = new HashSet<TblCustomerSchedule>();
            TblEmployeeDetail = new HashSet<TblEmployeeDetail>();
            TblMastTreatmentType = new HashSet<TblMastTreatmentType>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsMain { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual TblBranch Branch { get; set; }
        public virtual ICollection<TblCustomerGiftVoucher> TblCustomerGiftVoucher { get; set; }
        public virtual ICollection<TblCustomerInvoiceHeader> TblCustomerInvoiceHeader { get; set; }
        public virtual ICollection<TblCustomerSchedule> TblCustomerSchedule { get; set; }
        public virtual ICollection<TblEmployeeDetail> TblEmployeeDetail { get; set; }
        public virtual ICollection<TblMastTreatmentType> TblMastTreatmentType { get; set; }
    }
}
