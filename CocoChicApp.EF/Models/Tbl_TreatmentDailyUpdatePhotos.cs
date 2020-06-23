using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CocoChicApp.EF.Models
{
    public class Tbl_TreatmentDailyUpdatePhotos
    {
        [Key]
        public int Id { get; set; }
        public int Tduid { get; set; }
        public string CustomerId { get; set; }
        public string FileName { get; set; }

        public virtual Tbl_TreatmentDailyUpdate TreatmentDailyUpdate { get; set; }
    }
}
