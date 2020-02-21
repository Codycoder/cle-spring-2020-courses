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
        IRepository<Course> courseRepo;
        
        public CourseController(IRepository<Course> courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            courseRepo.Create(course);
            return RedirectToAction("Index");
        }
        
        public ViewResult Index()
        {
            var model = courseRepo.GetAll();
            
            return View(model);
        }

        public ViewResult Details(int id)
        {
            Course model = courseRepo.GetById(id);

            return View(model);
        }
    }
}
