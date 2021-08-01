using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Vegetables
{
    internal class Cucumber : IIngredient
    {
        public int Quantity;
        public double PricePerPiece = 0.4;

        public Cucumber(int quantity)
        {
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerPiece;
            return totalPrice;
        }
    }
}
