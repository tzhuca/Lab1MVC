using Lab1MVC.BusinessLayer;
using Lab1MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CourseBusinessLayer businessLayer= new CourseBusinessLayer();
            Course course = businessLayer.GetById(1);

            return View(course);
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
    }
}