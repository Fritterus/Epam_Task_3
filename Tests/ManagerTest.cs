using NUnit.Framework;
using FluentAssertions;
using Epam_Task_3;
using Epam_Task_3.Dishes.MeatDishes;
using Epam_Task_3.Dishes.Salads;
using Epam_Task_3.Drinks;

namespace Tests
{
    public class ManagerTest
    {

        [TestCase("Accept")]
        public void Manager_WhenOrderIsAccept_ReturnAcceptOrder(string expectedResult)
        {
            // Arrange
            var client = new Client();
            var clientId = client.Id;
            var dish = new ChickenInSauce();
            var drink = new Mojito();
            var order = new Order(dish, drink, clientId);
            var manager = new Manager();
            manager.AcceptOrder(order);

            // Act
            var result = order.Status;

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}