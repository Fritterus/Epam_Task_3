using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Oils
{
    internal class OliveOil : IIngredient
    {
        // Measured in tablespoons
        public int Quantity;
        // Olive oil price per one liter
        public double PricePerLiter = 12.4;
        // Quantity tablespoon per one liter
        public static int TablespoonPerLiter = 67;

        public OliveOil(int quantity)
        {
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerLiter / TablespoonPerLiter;
            return totalPrice;
        }
    }
}
