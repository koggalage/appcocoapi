using CocoChicApp.EF.Models;
using CocoChicApp.EF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.EF.Repositories
{
    public class ConsentFormDailyRepository : RepositoryBase<Tbl_ConsentFormDaily>, IConsentFormDailyRepository
    {
        public ConsentFormDailyRepository(BeautyPro_COCOContext context)
            : base(context)
        {

        }
    }
}
