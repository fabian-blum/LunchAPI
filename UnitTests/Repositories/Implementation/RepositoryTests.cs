using FluentAssertions;
using LunchAPI.Models;
using LunchAPI.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTests.Repositories.Implementation
{
    public class RepositoryTests
    {

        public RepositoryTests()
        {

        }

        private Repository<Meal> CreateRepository()
        {
            return new Repository<Meal>();
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repository = this.CreateRepository();
            var enity = new Meal()
            {
                Id = Guid.NewGuid(),
                Ingredients = new List<Ingredients>()
                {
                    new()
                    {
                        Id = Guid.NewGuid(),
                    },
                    new()
                    {
                        Id = Guid.NewGuid()
                    }
                }
            };

            // Act
            repository.Add(enity);

            // Assert
            var entries = repository.GetAll();
            entries.Should().HaveCount(1);
            entries.FirstOrDefault().Should().NotBeNull();
            entries.FirstOrDefault()?.Ingredients.Should().HaveCount(2);
        }
    }
}
