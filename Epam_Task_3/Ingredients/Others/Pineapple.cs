using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients
{
    /// <summary>
    /// This class describing ingredient - pinapple
    /// </summary>
    internal class Pineapple : IIngredient
    {
        public int Quantity;
        public double PricePerPiece = 3.2;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public Pineapple(int quantity)
        {
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is Pineapple pineapple &&
                   Quantity == pineapple.Quantity &&
                   PricePerPiece == pineapple.PricePerPiece;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Quantity, PricePerPiece);
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
            var totalPrice = Quantity * PricePerPiece;
            return totalPrice;
        }
    }
}
