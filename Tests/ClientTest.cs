using NUnit.Framework;
using FluentAssertions;
using Epam_Task_3;
using Epam_Task_3.Dishes.MeatDishes;
using Epam_Task_3.Dishes.Salads;
using System.Collections.Generic;
using Epam_Task_3.Drinks;
using System;

namespace Tests
{
    public class ClientTest
    {
        private static ChickenInSauce _chickenInSauce = new ChickenInSauce();
        private static CaesarSalad _caesarSalad = new CaesarSalad();
        private static SaladWithPrawn _saladWithPrawn = new SaladWithPrawn();
        private static DalgonCoffee _dalgonCoffee = new DalgonCoffee();
        private static Mojito _mojito = new Mojito();


        private static Dictionary<string, double> _menu = new Dictionary<string, double>()
        {
            { nameof(_chickenInSauce), _chickenInSauce.GetPrice() },
            { nameof(_caesarSalad), _caesarSalad.GetPrice() },
            { nameof(_saladWithPrawn), _saladWithPrawn.GetPrice() },
            { nameof(_dalgonCoffee), _dalgonCoffee.GetPrice() },
            { nameof(_mojito), _mojito.GetPrice() },
        };

        [Test]
        public void Client_WhenClientIdIsCorrect_ShouldReturnCorrectId()
        {
            var client1 = new Client();
            var client2 = new Client();
            var client3 = new Client();

            Assert.AreEqual(client1.Id, 1);
            Assert.AreEqual(client2.Id, 2);
            Assert.AreEqual(client3.Id, 3);
        }

        [Test]
        public void ViewMenu_WhenMenuCompiled_ShouldReturnCorrectMenu()
        {
            var expected = _menu;
            var client = new Client();
            var snackBar = new SnackBar();

            snackBar.MakeMenu();

            var result = client.ViewMenu();

            result.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void ViewMenu_WhenMenuNotCompiled_ShourldReturnException()
        {
            var client = new Client();
            Action result = () => client.ViewMenu();

            result.Should().Throw<Exception>().WithMessage("Menu not compiled yet");
        }
    }
}