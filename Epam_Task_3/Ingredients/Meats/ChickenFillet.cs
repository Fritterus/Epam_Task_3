using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients
{
    internal class ChickenFillet : IIngredient
    {
        // Measured in gram
        public int Weight;
        // Chicken fillet price per one kilogram
        public double PricePerKg = 6.7;
        // Quantity gram per one kilogram
        public static int GramPerKg = 1000;

        public ChickenFillet(int weight)
        {
            Weight = weight;
        }

        public double TotalPrice()
        {
            var totalPrice = Weight * PricePerKg / GramPerKg;
            return totalPrice;
        }
    }
}
