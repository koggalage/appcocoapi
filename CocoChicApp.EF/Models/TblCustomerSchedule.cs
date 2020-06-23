using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblCustomerSchedule
    {
        public TblCustomerSchedule()
        {
            TblCustomerScheduleTreatment = new HashSet<TblCustomerScheduleTreatment>();
        }

        public int Csid { get; set; }
        public string CustomerId { get; set; }
        public DateTime BookedDate { get; set; }
        public string Status { get; set; }
        public int DepartmentId { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public int EnteredBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual TblCustomer Customer { get; set; }
        public virtual TblMastDepartment Department { get; set; }
        public virtual ICollection<TblCustomerScheduleTreatment> TblCustomerScheduleTreatment { get; set; }
    }
}
