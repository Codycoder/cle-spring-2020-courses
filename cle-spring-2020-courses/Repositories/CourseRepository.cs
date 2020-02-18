using cle_spring_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public Dictionary<int, Course> courseDictionary;

        public CourseRepository()
        {
            courseDictionary = new Dictionary<int, Course>()
            {
                { 1, new Course("C# for Smarties", 1, "It's all you need to learn it all")},
                { 2, new Course("HTML, CSS, JS, oh my!", 2, "OMG, the front end will become your BFF") },
                { 3, new Course("Azure for Improving", 3, "Learn it to work there") }
            };
        }
        
        public IEnumerable<Course> GetAll()
        {
            return courseDictionary.Values;
        }

        public Course GetById(int num)
        {
            return courseDictionary[num];
        }
    }
}
