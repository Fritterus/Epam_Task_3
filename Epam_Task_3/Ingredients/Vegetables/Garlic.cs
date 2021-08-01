using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Vegetables
{
    internal class Garlic : IIngredient
    {
        public int QuantityCloves;
        public double PricePerPiece = 0.4;

        public Garlic(int quantityCloves)
        {
            QuantityCloves = quantityCloves;
        }

        public double TotalPrice()
        {
            var totalPrice = QuantityCloves * PricePerPiece;
            return totalPrice;
        }
    }
}
