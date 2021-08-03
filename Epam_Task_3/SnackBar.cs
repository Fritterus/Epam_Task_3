using Epam_Task_3.Dishes.MeatDishes;
using Epam_Task_3.Dishes.Salads;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Epam_Task_3
{
    internal class SnackBar
    {
        private static ChickenInSauce _chickenInSauce = new ChickenInSauce();
        private static CaesarSalad _caesarSalad = new CaesarSalad();
        private static SaladWithPrawn _saladWithPrawn = new SaladWithPrawn();

        public Dictionary<string, double> Menu = new Dictionary<string, double>();

        public List<IDish> Dishes = new List<IDish>()
        {
            _chickenInSauce,
            _caesarSalad,
            _saladWithPrawn,
        };

        public void MakeMenu()
        {
            foreach (var item in Dishes)
            {
                Menu.Add(nameof(item), item.GetPrice());
            }
        }
    }
}
