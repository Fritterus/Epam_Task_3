using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Vegetables
{
    /// <summary>
    /// This class describing ingredient - cucumber
    /// </summary>
    internal class Cucumber : IIngredient
    {
        public int Quantity;
        public double PricePerPiece = 0.4;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public Cucumber(int quantity)
        {
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is Cucumber cucumber &&
                   Quantity == cucumber.Quantity &&
                   PricePerPiece == cucumber.PricePerPiece;
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
