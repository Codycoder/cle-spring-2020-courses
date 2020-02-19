using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using cle_spring_2020_courses.Models;

namespace cle_spring_2020_courses.Tests
{
    public class AssignmentModelTests
    {
        Assignment model;

        public AssignmentModelTests()
        {
            model = new Assignment(1, "EF practice", "February 33", "relationships and sql");
        }

        [Fact]
        public void AssignmentModel_Sets_DueDate()
        {
            var result = model.DueDate;

            Assert.Equal("February 33", result);
        }

        [Fact]
        public void AssignmentModel_Sets_Id()
        {
            var result = model.Id;

            Assert.Equal(1, result);
        }

        [Fact]
        public void AssignmentModel_Sets_Name()
        {
            var result = model.Name;

            Assert.Equal("EF practice", result);
        }

        [Fact]
        public void AssignmentModel_Sets_Details()
        {
            var result = model.Details;

            Assert.Equal("relationships and sql", result);
        }

    }
}
