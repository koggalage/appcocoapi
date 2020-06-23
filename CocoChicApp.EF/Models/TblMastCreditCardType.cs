using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblMastCreditCardType
    {
        public TblMastCreditCardType()
        {
            TblCustomerInvoiceHeader = new HashSet<TblCustomerInvoiceHeader>();
        }

        public int Cctid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblCustomerInvoiceHeader> TblCustomerInvoiceHeader { get; set; }
    }
}
