using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblCustomerInvoiceTreatment
    {
        public int Citid { get; set; }
        public string InvoiceNo { get; set; }
        public int Ttid { get; set; }
        public int Empno { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int Cstid { get; set; }
        public int Qty { get; set; }

        public virtual TblCustomerScheduleTreatment Cst { get; set; }
        public virtual TblEmployeeDetail EmpnoNavigation { get; set; }
        public virtual TblCustomerInvoiceHeader InvoiceNoNavigation { get; set; }
        public virtual TblMastTreatmentType Tt { get; set; }
    }
}
