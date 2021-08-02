using Epam_Task_3.Dishes.MeatDishes;
using Epam_Task_3.Ingredients.Oils;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.DishesTests
{
    public class ChickenInSauceTest
    {
        private ChickenInSauce _chickenInSauce = new ChickenInSauce();

        [TestCase(16.86)]
        public void GetPrice_WhenExpectedIsMatch(double expectedResult)
        {
            var result = _chickenInSauce.GetPrice();

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(12.73)]
        public void GetPrice_WhenExpectedIsNotMatch(double expectedResult)
        {
            var result = _chickenInSauce.GetPrice();

            Assert.AreNotEqual(result, expectedResult);
        }

        [Test]
        public void GetPrice_WhenIngredientPriceEqualZero_ShouldReturnException()
        {
            _chickenInSauce.IngredientsList.Add(new OliveOil(0));
            Action result = () => _chickenInSauce.GetPrice();

            result.Should().Throw<Exception>().WithMessage("Price of this ingredient has not been set");
        }

    }
}