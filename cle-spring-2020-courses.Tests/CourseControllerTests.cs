using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using cle_spring_2020_courses.Controllers;

namespace cle_spring_2020_courses.Tests
{
    public class CourseControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            // Arrange
            var controller = new CourseController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);

        }
    }
}
