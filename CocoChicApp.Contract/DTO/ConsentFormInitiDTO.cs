using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Contract.DTO
{
    public class ConsentFormInitiDTO
    {
        public int Cfid { get; set; }
        public string CustomerId { get; set; }
        public bool? IsDiabetes { get; set; }
        public bool? IsHypertension { get; set; }
        public bool? IsHeartDisease { get; set; }
        public bool? IsAsthma { get; set; }
        public bool? IsSinuitis { get; set; }
        public bool? IsHyperlipidemia { get; set; }
        public bool? IsOther { get; set; }
        public bool? IsSurgical { get; set; }
        public bool? IsMarried { get; set; }
        public bool? IsSmoking { get; set; }
        public bool? IsAlcoholic { get; set; }
        public string CurrentMedication { get; set; }
        public bool? IsAllergies { get; set; }
        public bool? IsMenstrualAbnormalities { get; set; }
        public string CurrentlyUsedProduct { get; set; }
        public bool? IsAnySkinTreatment { get; set; }
        public string OtherDiseases { get; set; }
        public string SurgicalHistory { get; set; }
        public string KnownAllergies { get; set; }
        public string MenstrualAbnormalities { get; set; }
        public string PreviousSkinTreatments { get; set; }
        public bool IsClientSigned { get; set; }
        public bool IsTherapistSigned { get; set; }
        public int TherapistId { get; set; }
        public bool IsDoctorSinged { get; set; }
        public int DoctorId { get; set; }
        public int ConsentBy { get; set; }
        public DateTime ConsentDatetime { get; set; }
    }
}
