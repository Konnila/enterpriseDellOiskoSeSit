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
        private UserProfileService userService;

        public DoodelController()
        {
            doodelService = new DoodelService();
            userService = new UserProfileService();
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

            var doodel = doodelService.Get(x => x.Id == id).SingleOrDefault();
            var userDoodels = doodelService.GetUserDoodels().Where(x => x.DoodelId == doodel.Id);

            var doodleModel = new DoodleModel
            {
                Beginning = doodel.BeginTime,
                Ending = doodel.EndTime,
                Title = doodel.Title,
                Participants = new List<ParticipantDaysModel>()
                
            };

            foreach (var ud in userDoodels)
            {
                var days = doodelService.GetAllUserDoodleChoices()
                    .Where(x => x.UserDoodelId == ud.Id)
                    .Select(x => x.Day);
                doodleModel.Participants.Add(new ParticipantDaysModel
                {
                    User = userService.GetUser(ud.UserId).UserName,
                    Days = days.Select(x => x.Day1).ToList()
                });
            }

            return View(doodleModel);
        }



    }

    
}
