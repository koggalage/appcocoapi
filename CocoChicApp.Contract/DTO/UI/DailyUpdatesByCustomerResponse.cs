using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Contract.DTO.UI
{
    public class DailyUpdatesByCustomerResponse
    {
        public DateTime? Date { get; set; }
        public int Tduid { get; set; }
        public int? DoctorAppointmentId { get; set; }
        public string DoctorNote { get; set; }

    }
}
