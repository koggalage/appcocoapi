using CocoChicApp.EF.Models;
using CocoChicApp.EF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.EF.Repositories
{
    public class TreatmentDailyUpdateRepository : RepositoryBase<Tbl_TreatmentDailyUpdate>, ITreatmentDailyUpdateRepository
    {
        public TreatmentDailyUpdateRepository(BeautyPro_COCOContext context)
            : base(context)
        {

        }
    }
}
