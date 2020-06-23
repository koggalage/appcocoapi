using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblProductGinheader
    {
        public string Ginno { get; set; }
        public DateTime? Gindate { get; set; }
        public DateTime? SysDate { get; set; }
        public string Remarks { get; set; }
        public int? UserId { get; set; }
        public int? BranchId { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? IsDelete { get; set; }
        public int? IsDeletedBy { get; set; }
    }
}
