using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblMastPaymentType
    {
        public TblMastPaymentType()
        {
            TblCustomerGiftVoucher = new HashSet<TblCustomerGiftVoucher>();
            TblCustomerInvoiceHeader = new HashSet<TblCustomerInvoiceHeader>();
        }

        public int Ptid { get; set; }
        public string Ptname { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<TblCustomerGiftVoucher> TblCustomerGiftVoucher { get; set; }
        public virtual ICollection<TblCustomerInvoiceHeader> TblCustomerInvoiceHeader { get; set; }
    }
}
