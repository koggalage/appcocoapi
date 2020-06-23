using CocoChicApp.EF.Models;
using CocoChicApp.EF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.EF.Repositories
{
    public class ConsentFormInitiRepository : RepositoryBase<Tbl_ConsentFormIniti>, IConsentFormInitiRepository
    {
        public ConsentFormInitiRepository(BeautyPro_COCOContext context)
            : base(context)
        {

        }
    }
}
