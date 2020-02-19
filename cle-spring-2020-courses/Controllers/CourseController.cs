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
