using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Çizgi_School_Project.Models;

namespace Çizgi_School_Project.Controllers
{
    public class TeacherController : Controller 
        
    {
        CizgiSchoolDbEntities db = new CizgiSchoolDbEntities();
        // GET: Teacher
        public ActionResult Index()
        {
            var values = db.TblTeacher.ToList();
            return View(values);
        }
    }
}