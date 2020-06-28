using DataGenerator.Framework;
using DataGenerator.SampleProject.Models;
using Shouldly;
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
    }
}