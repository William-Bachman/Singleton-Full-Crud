using SingletonFullCRUD.Model;
using SingletonFullCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingletonFullCRUD.Controllers
{
    public class HomeController : Controller
    {
        private DB db = DB.Instance;

        public ActionResult Index()
        {
            return View(db.Bugs);
        }

        public ActionResult Details(int id)
        {
            Bug model = db.Bugs.FirstOrDefault(x => x.BugId == id);
            return View(model);
        }

        public ActionResult AddBug()
        {
            AddBugViewModel model = new AddBugViewModel();
            model.Bug = new Bug();
            model.Statuses = Enum.GetValues(typeof(Status)).Cast<Status>().ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddBug(Bug Bug)
        {
            Bug.BugId = db.Bugs.OrderByDescending(x => x.BugId).FirstOrDefault().BugId + 1;
            db.Bugs.Add(Bug);
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DeleteBug(int id)
        {
            Bug bug = db.Bugs.Where(x => x.BugId == id).FirstOrDefault();
            db.Bugs.Remove(bug);
            return RedirectToAction("Index");

        }
        public ActionResult EditBug(int id)
        {
             Bug Model = db.Bugs.FirstOrDefault(x => x.BugId == id);
            return View(Model);
        }
    }
}

















