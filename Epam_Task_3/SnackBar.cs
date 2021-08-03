using Epam_Task_3.Dishes.MeatDishes;
using Epam_Task_3.Dishes.Salads;
using Epam_Task_3.Drinks;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Epam_Task_3
{
    /// <summary>
    /// This class describing snack bar
    /// </summary>
    internal class SnackBar
    {
        private static ChickenInSauce _chickenInSauce = new ChickenInSauce();
        private static CaesarSalad _caesarSalad = new CaesarSalad();
        private static SaladWithPrawn _saladWithPrawn = new SaladWithPrawn();
        private static DalgonCoffee _dalgonCoffee = new DalgonCoffee();
        private static Mojito _mojito = new Mojito();

        // Dictionary menu includes dishes, drinks and prices
        public Dictionary<string, double> Menu = new Dictionary<string, double>();

        public List<IDish> Dishes = new List<IDish>()
        {
            _chickenInSauce,
            _caesarSalad,
            _saladWithPrawn,
        };

        public List<IDrink> Drinks = new List<IDrink>()
        {
            _dalgonCoffee,
            _mojito,
        };

        public void MakeMenu()
        {
            foreach (var item in Dishes)
            {
                Menu.Add(item.GetType().Name, item.GetPrice());
            }

            
        }
    }
}
