using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblCustomerGiftVoucher = new HashSet<TblCustomerGiftVoucher>();
            TblCustomerInvoiceHeader = new HashSet<TblCustomerInvoiceHeader>();
            TblCustomerSchedule = new HashSet<TblCustomerSchedule>();
        }

        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public string LoyaltyCardNo { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsFilledInitConcern { get; set; }
        public string SignatureURL { get; set; }
        public string NIC { get; set; }
        public virtual TblBranch Branch { get; set; }
        public virtual ICollection<TblCustomerGiftVoucher> TblCustomerGiftVoucher { get; set; }
        public virtual ICollection<TblCustomerInvoiceHeader> TblCustomerInvoiceHeader { get; set; }
        public virtual ICollection<TblCustomerSchedule> TblCustomerSchedule { get; set; }
    }
}
