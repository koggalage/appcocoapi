using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Contract.DTO
{
    public class ConsentFormDailyDTO
    {
        public int Cfdid { get; set; }
        public string CustomerId { get; set; }
        public DateTime ConsentDatetime { get; set; }
        public string NameOfTheTreatment { get; set; }
        public string PreviousListOfTreatment { get; set; }
        public string ExplainedBy { get; set; }
        public int ConsentBy { get; set; }
        public string Relationship { get; set; }
        public bool IsClientSigned { get; set; }
        public bool IsTherapistSigned { get; set; }
        public int DoctorId { get; set; }
        public bool IsDoctorSinged { get; set; }
        public string RelativeName { get; set; }
        public int TherapistId { get; set; }
        public string NIC { get; set; }

    }
}
