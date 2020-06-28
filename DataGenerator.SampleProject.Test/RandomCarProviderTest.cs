using DataGenerator.Framework;
using DataGenerator.SampleProject.Invalid;
using DataGenerator.SampleProject.Models;
using DataGenerator.SampleProject.Valid;
using Shouldly;
using System;
using System.Linq;
using Xunit;

namespace DataGenerator.SampleProject.Test
{
    public class RandomCarProviderTest
    {
        [Fact]
        public void ShouldReturnItemFromCarListProvider()
        {
            // Arrange
            var carListProvider = new CarListProvider();
            var sourceList = carListProvider.Fetch();
            var itemUnderTest = new RandomObjectProvider<Car>(carListProvider);

            // Act
            var result = itemUnderTest.Fetch();

            // Assert
            result.ShouldNotBeNull();
            result.ShouldBeOneOf(sourceList.ToArray());
        }


        [Fact]
        public void ShouldThrowExeptionWhenSourceListIsEmpty()
        {
            var carListProvider = new EmptyCarListProvider();
            var itemUnderTest = new RandomObjectProvider<Car>(carListProvider);

            Assert.Throws<InvalidOperationException>(() =>
            {
                itemUnderTest.Fetch();
            });
        }

        [Fact]
        public void ShouldThrowExeptionWhenSourceListIsNull()
        {
            var carListProvider = new NullCarListProvider();
            var itemUnderTest = new RandomObjectProvider<Car>(carListProvider);

            Assert.Throws<InvalidOperationException>(() =>
            {
                itemUnderTest.Fetch();
            });
        }
    }
}