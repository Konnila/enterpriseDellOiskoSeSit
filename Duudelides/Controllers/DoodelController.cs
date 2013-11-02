using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Duudelides.Filters;
using Duudelides.Framework;
using Duudelides.Services;
using Duudelides.ViewModels;
using WebMatrix.WebData;

namespace Duudelides.Controllers
{
    [InitializeSimpleMembership]
    public class DoodelController : Controller
    {
        //
        // GET: /Doodel/
        private DoodelService doodelService;

        public DoodelController()
        {
            doodelService = new DoodelService();
        }

        [Transaction]
        public ActionResult Index()
        {
            //list view
            var doodelListModel = new DoodelListingModel();
            doodelListModel.doodels =
                doodelService.GetUserDoodels()
                    .Where(x => x.UserId == WebSecurity.GetUserId(User.Identity.Name))
                    .Select(x => x.Doodel).ToList();

            return View(doodelListModel);
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

            var penis = User.Identity.Name;
            var userId = WebSecurity.GetUserId(penis);

            doodelService.CreateDoodel(model, userId);
           
            return RedirectToAction("Index", "Doodel", new { id = WebSecurity.GetUserId(penis) });
        }

        [HttpGet]
        public ActionResult MyDoodle(int id)
        {
            //todo: authorize


            return View();
        }

    }

    
}
