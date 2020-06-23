using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CocoChicApp.EF.Models
{
    public partial class Tbl_TreatmentDailyUpdate
    {
        [Key]
        public int Tduid { get; set; }
        public string CustomerId { get; set; }
        public DateTime? Date { get; set; }
        public string Problem { get; set; }
        public string DoctorNote { get; set; }
        public int? BranchId { get; set; }
        public int? UserId { get; set; }
        public bool? IsSkinCare { get; set; }
        public bool? IsSalon { get; set; }
        public bool? IsHair { get; set; }
        public bool? IsSpa { get; set; }
        public bool? IsPaid { get; set; }
        public int? DoctorAppointmentId { get; set; }
        public int? ServiceAppointmentId { get; set; }

        public virtual ICollection<Tbl_TreatmentDailyUpdatePhotos> TreatmentDailyUpdatePhotos { get; set; }
    }
}
