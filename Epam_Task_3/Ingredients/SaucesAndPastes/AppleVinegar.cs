using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.SaucesAndPastes
{
    /// <summary>
    /// This class describing ingredient - apple vinegar
    /// </summary>
    internal class AppleVinegar : IIngredient
    {
        // Measured in milliliter
        public int Quantity;
        public double PricePerLiter = 26.8;
        public static int MillilterPerLiter = 1000;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public AppleVinegar(int quantity)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// Method for getting ingredient total price
        /// </summary>
        /// <returns>total price</returns>
        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerLiter / MillilterPerLiter;
            return totalPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is AppleVinegar vinegar &&
                   Quantity == vinegar.Quantity &&
                   PricePerLiter == vinegar.PricePerLiter;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Quantity, PricePerLiter);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
