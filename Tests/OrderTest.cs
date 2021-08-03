using NUnit.Framework;
using Epam_Task_3;
using Epam_Task_3.Dishes.MeatDishes;
using Epam_Task_3.Drinks;

namespace Tests
{
    public class OrderTest
    {
        [TestCase(27.22)]
        public void Order_WhenOrderPriceIsCorrect_ShouldReturnCorrectPrice(double expectedResult)
        {
            // Arrange
            var client = new Client();
            var clinetId = client.Id;
            var dish = new ChickenInSauce();
            var drink = new Mojito();
            var order = new Order(dish, drink, clinetId);

            // Act
            var result = order.Cost;

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Order_WhenOrderIdIsCorrect_ShouldReturnCorrectId()
        {
            // Arrange
            var client = new Client();
            var clinetId = client.Id;
            var dish = new ChickenInSauce();
            var drink = new Mojito();
            var order1 = new Order(dish, drink, clinetId);
            var order2 = new Order(dish, drink, clinetId);
            var order3 = new Order(dish, drink, clinetId);

            // Act
            var result1 = order1.Id;
            var result2 = order2.Id;
            var result3 = order3.Id;

            // Assert
            Assert.AreEqual(result1, 2);
            Assert.AreEqual(result2, 3);
            Assert.AreEqual(result3, 4);
        }

        [TestCase("Awaiting")]
        public void Order_WhenOrderStatusIsCorrect_ShouldReturnCorrectStatus(string expectedResult)
        {
            // Arrange
            var client = new Client();
            var clinetId = client.Id;
            var dish = new ChickenInSauce();
            var drink = new Mojito();
            var order = new Order(dish, drink, clinetId);

            // Act
            var result = order.Status;

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}