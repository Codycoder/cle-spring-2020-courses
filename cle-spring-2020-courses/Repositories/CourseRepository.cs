using cle_spring_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Repositories
{
    public class CourseRepository : IRepository<CourseModel>
    {
        public IEnumerable<CourseModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
