using  DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.EmployeeProcessor;
using Hastane.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.EmployeeModel> Employees = new List<Hastane.Models.EmployeeModel>();
            foreach(var new_item in data)
            {
                Employees.Add(new Hastane.Models.EmployeeModel
                {
                    EmployeeId = new_item.EmployeeId,
                    FirstName = new_item.FirstName,
                    Surname = new_item.Surname,
                    Phone = new_item.Phone,
                    Gender = new_item.Gender,
                    Address = new_item.Address,
                    Salary = new_item.Salary
                });
            }
            
            return View(Employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.EmployeeModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                EmployeeProcessor.Create(E.EmployeeId, E.FirstName, E.Surname, E.Phone, E.Gender, E.Address, E.Salary);
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
        public ActionResult Edit(Models.EmployeeModel E)
        {
            if(AccountController.isItAdmin == true)
            {
                EmployeeProcessor.Edit(E.EmployeeId, E.FirstName, E.Surname, E.Phone, E.Gender, E.Address, E.Salary);
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
        public ActionResult Delete(Models.EmployeeModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                EmployeeProcessor.Delete(E.EmployeeId);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}