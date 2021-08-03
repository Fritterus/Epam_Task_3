using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Fruits
{
    /// <summary>
    /// This class describing ingredient - lime
    /// </summary>
    internal class Lime : IIngredient
    {
        // Measured in pices
        public int Quantity;
        // Lime price per piece
        public static double PricePerPiece = 4.3;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public Lime(int quantity)
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
            return obj is Lime lime &&
                   Quantity == lime.Quantity;
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
