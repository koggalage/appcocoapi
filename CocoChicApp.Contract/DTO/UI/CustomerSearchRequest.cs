using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Contract.DTO.UI
{
    public class CustomerSearchRequest
    {
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public string MobileNo { get; set; }
    }
}
