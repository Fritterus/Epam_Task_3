using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Others
{
    /// <summary>
    /// This class describing ingredient - water
    /// </summary>
    internal class Water : IIngredient
    {
        // Measured in milliliter
        public int Quantity;
        // Water price for one liter
        public double PricePerLiter = 0.1;
        // Quantity milliliter in one liter
        public int MilliterPerLiter = 1000;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public Water(int quantity)
        {
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is Water water &&
                   Quantity == water.Quantity &&
                   PricePerLiter == water.PricePerLiter &&
                   MilliterPerLiter == water.MilliterPerLiter;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Quantity, PricePerLiter, MilliterPerLiter);
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
            var totalPrice = Quantity * PricePerLiter / MilliterPerLiter;
            return totalPrice;
        }
    }
}
