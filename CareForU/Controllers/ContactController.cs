using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CareLib.Repository;

namespace CareForU.Controllers
{
    public class ContactController : Controller
    {
        IHomeContent _homeDB;
        public ContactController()
        {
            _homeDB = new HomeContentDal(new CareLib.Models.CareForYouEntities());
        }

        public ActionResult Index()
        {

            return View(_homeDB.getCompanyDetails());
        }

    }
}
