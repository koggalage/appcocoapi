using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblCompany
    {
        public TblCompany()
        {
            TblBranch = new HashSet<TblBranch>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<TblBranch> TblBranch { get; set; }
    }
}
