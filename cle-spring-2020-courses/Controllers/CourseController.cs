using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cle_spring_2020_courses.Models;
using cle_spring_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cle_spring_2020_courses.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            CourseRepository courseRepo = new CourseRepository();

            var model = courseRepo.GetAll();
            
            return View(model);
        }

        public ViewResult Details(int id)
        {
            CourseRepository courseRepo = new CourseRepository();

            CourseModel model = courseRepo.GetById(id);

            return View(model);
        }
    }
}
