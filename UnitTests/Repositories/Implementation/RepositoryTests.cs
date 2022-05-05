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

            var one = repository.Get(enity.Id);
            one.Should().NotBeNull();
            one?.Id.Should().Be(enity.Id);
        }

        [Fact]
        public void Update_StateUnderTest_ExpectedBehavior()
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

            enity.Ingredients = new List<Ingredients>()
            {
                new Ingredients()
                {
                    Id = Guid.NewGuid()
                }
            };

            repository.Update(enity);

            // Assert
            var entries = repository.GetAll();
            entries.Should().HaveCount(1);
            entries.FirstOrDefault().Should().NotBeNull();
            entries.FirstOrDefault()?.Ingredients.Should().HaveCount(1);
        }

        [Fact]
        public void Delete_StateUnderTest_ExpectedBehavior()
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
            repository.Remove(enity);

            // Assert
            var entries = repository.GetAll();
            entries.Should().HaveCount(0);
            entries.FirstOrDefault().Should().BeNull();
        }
    }
}
