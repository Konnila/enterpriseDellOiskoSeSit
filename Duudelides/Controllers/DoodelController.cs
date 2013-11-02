using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Duudelides.Framework;

namespace Duudelides.Controllers
{
    public class DoodelController : Controller
    {
        //
        // GET: /Doodel/
        private DoodelService doodelService;

        public DoodelController()
        {
            doodelService = new DoodelService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new DoodelCreateModel();
            
            return View();
        }

        [Transaction]
        [HttpPost]
        public ActionResult Create(DoodelCreateModel model)
        {
            DateTime begin = Convert.ToDateTime(model.Beginning);
            DateTime end = Convert.ToDateTime(model.Ending);

            doodelService.CreateDoodel(model);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult MyDoodles()
        {
            return RedirectToAction("Index");
        }



    }

    
}
