using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.SaucesAndPastes
{
    internal class SoySauce : IIngredient
    {
        // Soy Sauce is measured tablespoons
        public int Quantity;
        // Price soy sauce per one liter
        public double PricePerLiter = 9.39;
        // Quantity tablespoons in one liter
        public static int TablespoonPerLiter = 67;

        public SoySauce(int quantity)
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
