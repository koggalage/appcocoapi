using System;
using System.Collections.Generic;

namespace CocoChicApp.EF.Models
{
    public partial class TblCustomerScheduleTreatment
    {
        public TblCustomerScheduleTreatment()
        {
            TblCustomerInvoiceTreatment = new HashSet<TblCustomerInvoiceTreatment>();
        }

        public int Cstid { get; set; }
        public int Csid { get; set; }
        public int Ttid { get; set; }
        public int Empno { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Qty { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual TblCustomerSchedule Cs { get; set; }
        public virtual TblEmployeeDetail EmpnoNavigation { get; set; }
        public virtual TblMastTreatmentType Tt { get; set; }
        public virtual ICollection<TblCustomerInvoiceTreatment> TblCustomerInvoiceTreatment { get; set; }
    }
}
