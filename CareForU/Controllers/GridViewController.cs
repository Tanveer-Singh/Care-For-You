using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CareLib.Repository;

namespace CareForU.Controllers
{
    public class GridViewController : Controller
    {

        ICareDoctor _careDB;
        public GridViewController()
        {
            _careDB = new DoctorDal(new CareLib.Models.CareForYouEntities());
        }

        public ActionResult Index()
        {
            ViewBag.Tittle = "Meet Our Doctors";
            var test = _careDB.getAllDoctors();
            ViewData.Model = test;
            return View();
        }

    }
}
