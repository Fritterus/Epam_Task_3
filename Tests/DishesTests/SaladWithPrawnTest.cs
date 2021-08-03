using Epam_Task_3.Dishes.Salads;
using Epam_Task_3.Ingredients;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.DishesTests
{
    public class SaladWithPrawnTest
    {
        private SaladWithPrawn _saladWithPrawn = new SaladWithPrawn();

        [TestCase(29.6)]
        public void GetPrice_WhenExpectedIsMatch(double expectedResult)
        {
            // Arrange

            // Act
            var result = _saladWithPrawn.GetPrice();

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(13.47)]
        public void GetPrice_WhenExpectedIsNotMatch(double expectedResult)
        {
            // Arrange

            // Act
            var result = _saladWithPrawn.GetPrice();

            // Assert
            Assert.AreNotEqual(result, expectedResult);
        }

        [Test]
        public void GetPrice_WhenIngredientPriceEqualZero_ShouldReturnException()
        {
            // Arrange
            var sugar = new Sugar(0);
            _saladWithPrawn.IngredientsList.Add(sugar);

            // Act
            Action result = () => _saladWithPrawn.GetPrice();

            // Assert
            result.Should().Throw<Exception>().WithMessage("Price of this ingredient has not been set");
        }

    }
}