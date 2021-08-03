using NUnit.Framework;
using FluentAssertions;
using Epam_Task_3;
using Epam_Task_3.Dishes.MeatDishes;
using Epam_Task_3.Dishes.Salads;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test()
        {
            var client = new Client();
            var dish1 = new ChickenInSauce();
            var dish2 = new CaesarSalad();
            var dish3 = new SaladWithPrawn();
            var order1 = client.MakeOrder(dish1);
            var order2 = client.MakeOrder(dish2);
            var order3 = client.MakeOrder(dish3);

            Assert.AreEqual(order1.Id, 1);
            Assert.AreEqual(order2.Id, 2);
            Assert.AreEqual(order3.Id, 3);
        }
    }
}