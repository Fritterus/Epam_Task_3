using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Others
{
    /// <summary>
    /// This class describing ingredient - cacao
    /// </summary>
    internal class Cacao : IIngredient
    {
        public int Quantity;
        public double PricePerPiece = 4.4;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public Cacao(int quantity)
        {
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is Cacao cacao &&
                   Quantity == cacao.Quantity &&
                   PricePerPiece == cacao.PricePerPiece;
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
