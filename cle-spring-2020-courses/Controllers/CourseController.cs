using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cle_spring_2020_courses.Models;
using Microsoft.AspNetCore.Mvc;

namespace cle_spring_2020_courses.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            CourseModel model = new CourseModel("Calculus 101", 1, "Beware, it's some difficult math");
            return View(model);
        }

    }
}
