using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblCustomerGiftVoucher
    {
        public string GvinvoiceNo { get; set; }
        public string VoucherNo { get; set; }
        public string CustomerId { get; set; }
        public DateTime InvDateTime { get; set; }
        public int BranchId { get; set; }
        public int? Ttid { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DueAmount { get; set; }
        public int? DepartmentId { get; set; }
        public int Ptid { get; set; }
        public bool IsRedeem { get; set; }
        public bool IsCanceled { get; set; }
        public string CancelReason { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CanceledBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CanceledDate { get; set; }
        public string TransType { get; set; }

        public virtual TblCustomer Customer { get; set; }
        public virtual TblMastDepartment Department { get; set; }
        public virtual TblMastPaymentType Pt { get; set; }
        public virtual TblMastTreatmentType Tt { get; set; }
    }
}
