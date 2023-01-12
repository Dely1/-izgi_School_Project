using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Çizgi_School_Project.Models;

namespace Çizgi_School_Project.Controllers
{
    public class StudentController : Controller
    {
        CizgiSchoolDbEntities db = new CizgiSchoolDbEntities();
        public ActionResult Index()
        {
            var values = db.TblStudent.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        public ActionResult AddStudent(TblStudent p)
        {
            db.TblStudent.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteStudent(int id)
        {
            var values = db.TblStudent.Find(id);
            db.TblStudent.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult UpdateStudent(int id) 
        {
            var values = db.TblStudent.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateStudent(TblStudent p)
        {
            var values = db.TblStudent.Find(p.StudentId);
            values.Name = p.Name;
            values.SurName = p.SurName;
            values.Mail = p.Mail;
            values.İmage = p.İmage;
            values.Number = p.Number;
            values.PhoneNumbar = p.PhoneNumbar;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}