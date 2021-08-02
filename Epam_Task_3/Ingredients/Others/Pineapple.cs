using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients
{
    internal class Pineapple : IIngredient
    {
        public int Quantity;
        public double PricePerPiece = 3.2;

        public Pineapple(int quantity)
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
