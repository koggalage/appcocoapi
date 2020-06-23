using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblMastProductUnits
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
        public int? BranchId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
