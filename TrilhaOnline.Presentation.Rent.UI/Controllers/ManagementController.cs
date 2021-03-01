using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrilhaOnline.Presentation.Rent.UI.Models.Car;
using TrilhaOnline.Presentation.Rent.UI.Services;
using TrilhaOnline.Presentation.Rent.UI.Services.Rent;

namespace TrilhaOnline.Presentation.Rent.UI.Controllers
{
    public class ManagementController : Controller
    {
        private RentServices _services;
        public ManagementController()
        {
            _services = new RentServices();
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cars()
        {
            var models = _services._callGetAllCars();

            return View(models);
        }

        public ActionResult partialCreateCars()
        {
            return View();
        }

        [HttpPost]
        public ActionResult partialCreateCars(FormCollection data)
        {
            return View();
        }

        public ActionResult partialDetailsCars()
        {
            return View();
        }
         
        [HttpPost]
        public ActionResult partialDetailsCars(int id)
        {
            return View();
        }
    }
}