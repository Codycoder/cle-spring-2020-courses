using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using cle_spring_2020_courses.Models;


namespace cle_spring_2020_courses.Tests
{
    public class CourseModelTests
    {
        Course model;
        
        public CourseModelTests()
        {
            model = new Course("Course Name", 42, "Statistics");
        }
        
        [Fact]
        public void CourseConstructor_Sets_Name_on_Course()
        {
            var result = model.Name;

            Assert.Equal("Course Name", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Id_on_Course()
        {
            var result = model.Id;

            Assert.Equal(42, result);
        }

        [Fact]
        public void CourseConstructor_Sets_Description_on_Course()
        {
            var result = model.Description;

            Assert.Equal("Statistics", result);
        }
    }
}
