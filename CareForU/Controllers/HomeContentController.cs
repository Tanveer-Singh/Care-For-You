using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CareLib.Models;
using CareLib.Repository;
using System.Web.Security;

namespace CareForU.Controllers
{
    [Authorize]
    public class HomeContentController : Controller
    {
        IHomeContent _HomeDb;
        public HomeContentController()
        {
            _HomeDb = new CareLib.Repository.HomeContentDal(new CareForYouEntities());
        }

        public ActionResult Create()
        {
            if (Roles.IsUserInRole(CareRules.Admin.ToString()) && Roles.IsUserInRole(CareRules.Users.ToString()))
            {
                return View();
            }
            else if (Roles.IsUserInRole(CareRules.Admin.ToString()))
            {
                return View();
            }
            else if (Roles.IsUserInRole(CareRules.Users.ToString()))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "SuperAdmin");
            }

        }

        //
        // POST: /HomeContent/Create

        [HttpPost]
        public ActionResult Create(HomeContent collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool SaveResult = _HomeDb.InsertHomeContent(collection);
                    if (SaveResult)
                    {
                        return Redirect("/");
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /HomeContent/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HomeContent/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /HomeContent/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /HomeContent/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
