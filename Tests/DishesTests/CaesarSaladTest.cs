using Epam_Task_3.Dishes.Salads;
using Epam_Task_3.Ingredients.Vegetables;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.DishesTests
{
    public class CaesarSaladTest
    {
        private CaesarSalad _caesarSalad = new CaesarSalad();

        [TestCase(7.61)]
        public void GetPrice_WhenExpectedIsMatch(double expectedResult)
        {
            // Arrange

            // Act
            var result = _caesarSalad.GetPrice();

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(9.12)]
        public void GetPrice_WhenExpectedIsNotMatch(double expectedResult)
        {
            // Arrange

            // Act
            var result = _caesarSalad.GetPrice();

            // Assert
            Assert.AreNotEqual(result, expectedResult);
        }

        [Test]
        public void GetPrice_WhenIngredientPriceEqualZero_ShouldReturnException()
        {
            // Arrange
            var cucumber = new Cucumber(0);
            _caesarSalad.IngredientsList.Add(cucumber);

            // Act
            Action result = () => _caesarSalad.GetPrice();

            // Assert
            result.Should().Throw<Exception>().WithMessage("Price of this ingredient has not been set");
        }

    }
}