using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTorre.Controllers
{
    public class ElectrodomesticosController : Controller
    {
        // GET: Electrodomesticos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexAdministrador()
        {
            return View();
        }
    }
}