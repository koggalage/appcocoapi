using CocoChicApp.EF.Models;
using CocoChicApp.EF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocoChicApp.EF.Repositories
{
    public class TreatmentDailyUpdatePhotosRepository : RepositoryBase<Tbl_TreatmentDailyUpdatePhotos>, ITreatmentDailyUpdatePhotosRepository
    {
        public TreatmentDailyUpdatePhotosRepository(BeautyPro_COCOContext context)
            : base(context)
        {

        }
    }
}
