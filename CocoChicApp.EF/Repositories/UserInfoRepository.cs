using CocoChicApp.EF.Models;
using CocoChicApp.EF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.EF.Repositories
{
    public class UserInfoRepository : RepositoryBase<TblUser>, IUserInfoRepository
    {
        public UserInfoRepository(BeautyPro_COCOContext context)
            : base(context)
        {

        }
    }
}
