using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.SaucesAndPastes
{
    internal class AppleVinegar : IIngredient
    {
        // Measured in milliliter
        public int Quantity;
        public double PricePerLiter = 26.8;
        public static int MillilterPerLiter = 1000;
        public AppleVinegar(int quantity)
        {
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerLiter / MillilterPerLiter;
            return totalPrice;
        }
    }
}
