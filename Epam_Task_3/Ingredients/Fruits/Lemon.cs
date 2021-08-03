using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Fruits
{
    /// <summary>
    /// This class describing ingredient - lemon
    /// </summary>
    internal class Lemon : IIngredient
    {
        // Measured in pices
        public int Quantity;
        // Lemon price per piece
        public static double PricePerPiece = 3.2;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public Lemon(int quantity)
        {
            Quantity = quantity;
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

        public override bool Equals(object obj)
        {
            return obj is Lemon lemon &&
                   Quantity == lemon.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Quantity);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
