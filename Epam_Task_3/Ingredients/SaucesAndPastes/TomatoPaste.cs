using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.SaucesAndPastes
{
    internal class TomatoPaste : IIngredient
    {
        // Measured in tablespoons
        public int Quantity;
        // Tomato paste price per one liter
        public double PricePerLiter = 9.3;
        // Quantity tablespoon per one liter
        public static int TablespoonPerLiter = 67;

        public TomatoPaste(int quantity)
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
