using DataLibrary.Logic;
using DataLibrary.Models;
using static DataLibrary.Logic.RoomProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        public ActionResult Index()
        {
            var data = Load();
            List<Hastane.Models.RoomModel> Rooms = new List<Hastane.Models.RoomModel>();
            foreach (var new_item in data)
            {
                Rooms.Add(new Hastane.Models.RoomModel
                {
                    RoomNo = new_item.RoomNo
                });
            }

            return View(Rooms);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.RoomModel room)
        {
            if(AccountController.isItAdmin == true)
            {
                RoomProcessor.Create(room.RoomNo);
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
        public ActionResult Edit(Models.RoomModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                //RoomProcessor.Edit(E.RoomNo);
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
        public ActionResult Delete(Models.RoomModel E)
        {
            if (AccountController.isItAdmin == true)
            {
                RoomProcessor.Delete(E.RoomNo);
                return RedirectToAction("Authenticated", "Admin");
            }
            else
            {
                return RedirectToAction("NotAuthenticated", "Admin");
            }
        }
    }
}