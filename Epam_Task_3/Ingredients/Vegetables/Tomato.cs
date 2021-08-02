using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Vegetables
{
    internal class Tomato : IIngredient
    {
        public int Quantity;
        public double PricePerPiece = 2.6;

        public Tomato(int quantity)
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
