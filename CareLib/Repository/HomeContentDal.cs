using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CareLib.Models;

namespace CareLib.Repository
{
    public class HomeContentDal:IHomeContent
    {
        CareLib.Models.CareForYouEntities _Homedb;
        public HomeContentDal(CareLib.Models.CareForYouEntities DB)
        {
            _Homedb = DB;
        }
        public bool InsertHomeContent(Models.HomeContent HomeEntity)
        {
            if (HomeEntity != null)
            {
                _Homedb.AddToHomeContents(HomeEntity);
                _Homedb.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Models.HomeContent> getAllHomeContent()
        {
            return _Homedb.HomeContents.ToList();

        }


        public CompanyDetail getCompanyDetails()
        {
            return _Homedb.CompanyDetails.ToList().SingleOrDefault();
        }
    }
}
