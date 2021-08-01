using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients
{
    internal class Sugar : IIngredient
    {
        // Sugar is measured in teaspoons
        public int Quantity;
        // Sugar price per one kilogram
        public double PricePerKg = 1.69;
        // Quantity teaspoon in one kilogram of sugar
        public static int TeaspoonPerKg = 143;

        public Sugar(int quantity)
        {
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerKg / TeaspoonPerKg;
            return totalPrice;
        }
    }
}
