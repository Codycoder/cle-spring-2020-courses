using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cle_spring_2020_courses.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

    }
}
