using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblCustomerInvoiceHeader
    {
        public TblCustomerInvoiceHeader()
        {
            TblCustomerInvoiceProducts = new HashSet<TblCustomerInvoiceProducts>();
            TblCustomerInvoiceTreatment = new HashSet<TblCustomerInvoiceTreatment>();
        }

        public string InvoiceNo { get; set; }
        public string CustomerId { get; set; }
        public DateTime InvDateTime { get; set; }
        public int BranchId { get; set; }
        public string TransType { get; set; }
        public int Ptid { get; set; }
        public int DepartmentId { get; set; }
        public string GvinvoiceNo { get; set; }
        public string CancelReason { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CanceledBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CanceledDate { get; set; }
        public string AmendedReason { get; set; }
        public int? CustomerScheduleTreatmentCstid { get; set; }
        public bool? IsAmended { get; set; }
        public int? Cctid { get; set; }
        public decimal ProductDueAmount { get; set; }
        public decimal ProductSubTotalAmount { get; set; }
        public decimal ProductTaxAmount { get; set; }
        public decimal TreatmentDiscountAmount { get; set; }
        public decimal TreatmentDueAmount { get; set; }
        public decimal TreatmentSubTotalAmount { get; set; }
        public decimal TreatmentTaxAmount { get; set; }
        public int Status { get; set; }

        public virtual TblMastCreditCardType Cct { get; set; }
        public virtual TblCustomer Customer { get; set; }
        public virtual TblMastDepartment Department { get; set; }
        public virtual TblMastPaymentType Pt { get; set; }
        public virtual ICollection<TblCustomerInvoiceProducts> TblCustomerInvoiceProducts { get; set; }
        public virtual ICollection<TblCustomerInvoiceTreatment> TblCustomerInvoiceTreatment { get; set; }
    }
}
