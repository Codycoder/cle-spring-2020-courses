 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Models
{
    public class Assignment
    {
        public string DueDate { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        public virtual Course Course { get; set; }
        public virtual int CourseId { get; set; }

        public Assignment()
        {

        }

        public Assignment(int id, string name, string dueDate, string details)
        {
            Id = id;
            Name = name;
            DueDate = dueDate;
            Details = details;
        }

    }
}
