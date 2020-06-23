using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblProductReceptionGrnheader
    {
        public string ReceptionGrnno { get; set; }
        public DateTime Grndate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Remarks { get; set; }
        public bool IsDelete { get; set; }
        public int? IsDeletedBy { get; set; }
        public int? BranchId { get; set; }
        public int? UserId { get; set; }
    }
}
