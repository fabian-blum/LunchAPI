using FluentAssertions;
using LunchAPI.Controllers;
using LunchAPI.Models;
using LunchAPI.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Xunit;

namespace UnitTests.Controllers
{
    public class MealControllerTests
    {
        private ILogger<MealController> subLogger;
        private IRepository<Meal> subRepository;

        public MealControllerTests()
        {
            this.subLogger = Substitute.For<ILogger<MealController>>();
            this.subRepository = Substitute.For<IRepository<Meal>>();
        }

        private MealController CreateMealController()
        {
            return new MealController(
                this.subLogger,
                this.subRepository);
        }

        [Fact]
        public void GetAll_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mealController = this.CreateMealController();

            // Act
            var result = mealController.GetAll();

            // Assert
            result.Should().BeEmpty();
        }
    }
}
