using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients
{
    internal class WhiteBread : IIngredient
    {
        public int QuantityPieces;
        public double PricePerPiece = 0.3;

        public WhiteBread(int quantityPieces)
        {
            QuantityPieces = quantityPieces;
        }

        public double TotalPrice()
        {
            var totalPrice = QuantityPieces * PricePerPiece;
            return totalPrice;
        }
    }
}
