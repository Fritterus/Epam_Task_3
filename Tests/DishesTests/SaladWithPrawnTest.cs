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
            var result = _saladWithPrawn.GetPrice();

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(13.47)]
        public void GetPrice_WhenExpectedIsNotMatch(double expectedResult)
        {
            var result = _saladWithPrawn.GetPrice();

            Assert.AreNotEqual(result, expectedResult);
        }

        [Test]
        public void GetPrice_WhenIngredientPriceEqualZero_ShouldReturnException()
        {
            _saladWithPrawn.IngredientsList.Add(new Sugar(0));
            Action result = () => _saladWithPrawn.GetPrice();

            result.Should().Throw<Exception>().WithMessage("Price of this ingredient has not been set");
        }

    }
}