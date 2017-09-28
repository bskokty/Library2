using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library2.Models;

namespace Library2.Controllers
{
    public class HomeController : Controller
    {

        BOOKSTOREEntities db = new BOOKSTOREEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {

            Books model = new Books();
            Publishers model1 = new Publishers();

            model.BookName = form["bookName"];
            model.Writer = form["writer"];
            model.PublisherName = form["publisher"];
            model1.PublisherName = form["publisher"];
            model.PublishDate = Convert.ToDateTime(form["datetimepicker1"]);

            db.Books.Add(model);
            db.Publishers.Add(model1);
            db.SaveChanges();



            return View();
        }

        public ActionResult Update()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult List()
        {
           

            return View(db.Books.ToList());
        }

        public ActionResult Delete()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}