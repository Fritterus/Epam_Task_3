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
            var dish = new ChickenInSauce();
            var drink = new Mojito();

            var order = new Order(dish, drink);

            Assert.AreEqual(order.Cost, expectedResult);
        }

        [Test]
        public void Order_WhenOrderIdIsCorrect_ShouldReturnCorrectId()
        {
            var dish = new ChickenInSauce();
            var drink = new Mojito();

            var order1 = new Order(dish, drink);
            var order2 = new Order(dish, drink);
            var order3 = new Order(dish, drink);

            Assert.AreEqual(order1.Id, 2);
            Assert.AreEqual(order2.Id, 3);
            Assert.AreEqual(order3.Id, 4);
        }

        [TestCase("Awaiting")]
        public void Order_WhenOrderStatusIsCorrect_ShouldReturnCorrectStatus(string expectedResult)
        {
            var dish = new ChickenInSauce();
            var drink = new Mojito();

            var order = new Order(dish, drink);

            Assert.AreEqual(order.Status, expectedResult);
        }
    }
}