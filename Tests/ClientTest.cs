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
            // Arrange
            var client1 = new Client();
            var client2 = new Client();
            var client3 = new Client();

            // Act
            var id1 = client1.Id;
            var id2 = client2.Id;
            var id3 = client3.Id;

            // Assert
            Assert.AreEqual(id1, 1);
            Assert.AreEqual(id2, 2);
            Assert.AreEqual(id3, 3);
        }

        [Test]
        public void ViewMenu_WhenMenuCompiled_ShouldReturnCorrectMenu()
        {
            // Arrange
            var expectedResult = _menu;
            var client = new Client();
            var manager = new Manager();
            manager.MakeMenu();

            // Act
            var result = client.ViewMenu();

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void ViewMenu_WhenMenuNotCompiled_ShourldReturnException()
        {
            // Arrange
            var client = new Client();

            // Act
            Action result = () => client.ViewMenu();

            // Assert
            result.Should().Throw<Exception>().WithMessage("Menu not compiled yet");
        }
    }
}