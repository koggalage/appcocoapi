using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblProductSellingPrice
    {
        public TblProductSellingPrice()
        {
            TblProduct = new HashSet<TblProduct>();
        }

        public string ItemId { get; set; }
        public decimal? SellingPrice { get; set; }

        public virtual ICollection<TblProduct> TblProduct { get; set; }
    }
}
