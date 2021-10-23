using Lab1MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.BusinessLayer
{
    public class CourseBusinessLayer
    {
        public Course GetById(int id)
        {
            Course c = new Course();
            c.Id = 1;
            c.Name = "ASP.NET MVC";
            return c;
        }
       
    }
}