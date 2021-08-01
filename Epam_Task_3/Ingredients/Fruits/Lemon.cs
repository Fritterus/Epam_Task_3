using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Fruits
{
    internal class Lemon : IIngredient
    {
        // Measured in pices
        public int Quantity;
        // Lemon price per piece
        public static double PricePerPiece = 3.2;

        public Lemon(int quantity)
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
