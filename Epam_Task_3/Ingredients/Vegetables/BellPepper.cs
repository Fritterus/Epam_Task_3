using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Vegetables
{
    /// <summary>
    /// This class describing ingredient - bell pepper
    /// </summary>
    internal class BellPepper : IIngredient
    {
        public int Quantity;
        public double PricePerPiece = 2.3;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public BellPepper(int quantity)
        {
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is BellPepper pepper &&
                   Quantity == pepper.Quantity &&
                   PricePerPiece == pepper.PricePerPiece;
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
