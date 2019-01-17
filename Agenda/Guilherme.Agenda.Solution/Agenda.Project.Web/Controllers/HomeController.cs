using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Project.Web.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }



        //Contato contato = new Contato();

        //public void Nome() {
        //    contato.Nome 
        //}


        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}