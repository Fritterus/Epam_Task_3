using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients
{
    /// <summary>
    /// This class describing ingredient - white bread
    /// </summary>
    internal class WhiteBread : IIngredient
    {
        public int QuantityPieces;
        public double PricePerPiece = 0.3;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public WhiteBread(int quantityPieces)
        {
            QuantityPieces = quantityPieces;
        }

        public override bool Equals(object obj)
        {
            return obj is WhiteBread bread &&
                   QuantityPieces == bread.QuantityPieces &&
                   PricePerPiece == bread.PricePerPiece;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(QuantityPieces, PricePerPiece);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Method for getting ingredient total price
        /// </summary>
        /// <returns>total price</returns>
        public double TotalPrice()
        {
            var totalPrice = QuantityPieces * PricePerPiece;
            return totalPrice;
        }
    }
}
