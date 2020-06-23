using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.Contract.DTO.UI
{
    public class LoginReponse
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string UserType { get; set; }
        public bool? IsActive { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string MobNo { get; set; }
        public int? BranchId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
