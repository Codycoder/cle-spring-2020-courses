using cle_spring_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Repositories
{
    public class CourseRepository : IRepository<CourseModel>
    {
        public Dictionary<int, CourseModel> courseDictionary;

        public CourseRepository()
        {
            courseDictionary = new Dictionary<int, CourseModel>()
            {
                { 1, new CourseModel("C# for Smarties", 1, "It's all you need to learn it all")},
                { 2, new CourseModel("HTML, CSS, JS, oh my!", 2, "OMG, the front end will become your BFF") },
                { 3, new CourseModel("Azure for Improving", 3, "Learn it to work there") }
            };
        }
        
        public IEnumerable<CourseModel> GetAll()
        {
            return courseDictionary.Values;
        }

        public CourseModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
