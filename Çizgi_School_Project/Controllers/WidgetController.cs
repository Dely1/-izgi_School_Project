using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Çizgi_School_Project.Models;

namespace Çizgi_School_Project.Controllers
{
    public class WidgetController : Controller
    {
        CizgiSchoolDbEntities db = new CizgiSchoolDbEntities();
        // GET: Widget
        public ActionResult Index()
        {
            ViewBag.V1 = 964;
            ViewBag.V2 = 50;
            ViewBag.V3 = 15;
            ViewBag.V4 =84.36;
            return View();
        }
    }
}