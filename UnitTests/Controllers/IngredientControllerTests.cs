using LunchAPI.Controllers;
using Microsoft.Extensions.Logging;
using NSubstitute;
using System;
using Xunit;

namespace UnitTests.Controllers
{
    public class IngredientControllerTests
    {
        private ILogger<IngredientController> subLogger;

        public IngredientControllerTests()
        {
            this.subLogger = Substitute.For<ILogger<IngredientController>>();
        }

        private IngredientController CreateIngredientController()
        {
            return new IngredientController(
                this.subLogger);
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var ingredientController = this.CreateIngredientController();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
