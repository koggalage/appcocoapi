﻿using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblProductGindetails
    {
        public string Ginno { get; set; }
        public string ItemNo { get; set; }
        public decimal? Price { get; set; }
        public decimal? Qty { get; set; }
        public string Remarks { get; set; }
        public decimal? Amount { get; set; }
    }
}
