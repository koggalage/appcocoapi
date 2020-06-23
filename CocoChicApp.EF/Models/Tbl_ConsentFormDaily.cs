using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CocoChicApp.EF.Models
{
    public class Tbl_ConsentFormDaily
    {
        [Key]
        public int Cfdid { get; set; }
        public string CustomerId { get; set; }
        public DateTime ConsentDatetime { get; set; }
        public string NameOfTheTreatment { get; set; }
        public string PreviousListOfTreatment { get; set; }
        public string ExplainedBy { get; set; }
        public int ConsentBy { get; set; }
        public string Relationship { get; set; }
        public bool IsClientSigned { get; set; }
        public int TherapistId { get; set; }
        public bool IsTherapistSigned { get; set; }
        public int DoctorId { get; set; }
        public bool IsDoctorSinged { get; set; }
        public string RelativeName { get; set; }
    }
}
