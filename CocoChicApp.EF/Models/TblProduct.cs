using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblCustomerInvoiceProducts = new HashSet<TblCustomerInvoiceProducts>();
        }

        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int? CatId { get; set; }
        public decimal? MaxQty { get; set; }
        public decimal? MinQty { get; set; }
        public decimal? LeadTime { get; set; }
        public decimal? ReOrderLevel { get; set; }
        public decimal? ReOrderQty { get; set; }
        public int? UnitId { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public int? BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public string Barcode { get; set; }
        public string ProductSellingPriceItemId { get; set; }

        public virtual TblProductSellingPrice ProductSellingPriceItem { get; set; }
        public virtual ICollection<TblCustomerInvoiceProducts> TblCustomerInvoiceProducts { get; set; }
    }
}
