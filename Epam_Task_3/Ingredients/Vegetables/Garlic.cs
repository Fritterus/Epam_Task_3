using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Vegetables
{
    /// <summary>
    /// This class describing ingredient - garlic
    /// </summary>
    internal class Garlic : IIngredient
    {
        public int QuantityCloves;
        public double PricePerPiece = 0.4;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public Garlic(int quantityCloves)
        {
            QuantityCloves = quantityCloves;
        }

        public override bool Equals(object obj)
        {
            return obj is Garlic garlic &&
                   QuantityCloves == garlic.QuantityCloves &&
                   PricePerPiece == garlic.PricePerPiece;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(QuantityCloves, PricePerPiece);
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
            var totalPrice = QuantityCloves * PricePerPiece;
            return totalPrice;
        }
    }
}
