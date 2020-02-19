using cle_spring_2020_courses.Models;
using cle_spring_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Controllers
{
    public class InstructorController : Controller
    {
        IRepository<Instructor> instRepo;

        public InstructorController(IRepository<Instructor> instRepo)
        {
            this.instRepo = instRepo;
        }

        public ViewResult Index()
        {
            var model = instRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = instRepo.GetById(id);

            return View(model);
        }
    }
}
