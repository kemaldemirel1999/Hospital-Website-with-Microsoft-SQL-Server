using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.OtherStaffProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class Other_StaffController : Controller
    {
        // GET: Other_Staff
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.OtherStaffModel> OtherStaffs = new List<Hastane.Models.OtherStaffModel>();
            foreach (var new_item in data)
            {
                OtherStaffs.Add(new Hastane.Models.OtherStaffModel
                {
                    EmpId = new_item.EmpId,
                });
            }

            return View(OtherStaffs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.OtherStaffModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                OtherStaffProcessor.Create(E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Models.OtherStaffModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                OtherStaffProcessor.Edit(E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Models.OtherStaffModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                OtherStaffProcessor.Delete(E.EmpId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}