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

        public ActionResult Details(int Docid = 0)
        {
            var DocDetails = (Docid > 0) ? _careDB.GetDoctorDetailsByID(Docid) : null;
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Details", DocDetails);
                //return View(DocDetails);
            }
            else
            {
                return View(DocDetails);
            }
 
        }


    }
}
