using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblConfig
    {
        public int ConfigId { get; set; }
        public decimal AbsentDeductionRatio { get; set; }
        public decimal PresentAllawancesRatio { get; set; }
    }
}
