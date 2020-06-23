using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblProductReceptionGrndetail
    {
        public string ReceptionGrnno { get; set; }
        public string ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
