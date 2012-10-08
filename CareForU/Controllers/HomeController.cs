using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CareLib.Repository;

namespace CareForU.Controllers
{
    public class HomeController : Controller
    {
        IHomeContent _HomeDb;
        public HomeController()
        {
            _HomeDb = new HomeContentDal(new CareLib.Models.CareForYouEntities());
        }

        public ActionResult Index()
        {
            return View(_HomeDb.getAllHomeContent());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
