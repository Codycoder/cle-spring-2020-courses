﻿using cle_spring_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private UniversityContext db;

        public CourseRepository(UniversityContext db)
        {
            this.db = db;
        }

        public void Create(Course course)
        {
            db.Courses.Add(course);
            db.SaveChanges();
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses;
        }

        public Course GetById(int id)
        {
            return db.Courses.Single(c => c.Id == id);
        }
    }
}
