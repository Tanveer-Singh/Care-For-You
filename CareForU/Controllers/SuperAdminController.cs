﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CareForU.Controllers
{
    public class SuperAdminController : Controller
    {
        //
        // GET: /SuperAdmin/

        public ActionResult Index()
        {
            var Users = Roles.GetRolesForUser();
            TempData["Users"] = Users;
            return View();
        }

        public ActionResult GetUser(string roleName)
        {
            var allUsers = Roles.GetUsersInRole(roleName);
            ViewData["AllUsers"] = allUsers;
            return View("Index");
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SuperAdmin/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SuperAdmin/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /SuperAdmin/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SuperAdmin/Edit/5

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
        // GET: /SuperAdmin/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SuperAdmin/Delete/5

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
