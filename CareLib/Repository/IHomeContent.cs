using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CareLib.Models;

namespace CareLib.Repository
{
    public interface IHomeContent
    {

        bool InsertHomeContent(HomeContent HomeEntity);
        List<HomeContent> getAllHomeContent();
        // Get Company Details for Google Maps
        CompanyDetail getCompanyDetails();
    }
}
