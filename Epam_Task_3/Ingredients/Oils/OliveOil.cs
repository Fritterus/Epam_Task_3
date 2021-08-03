using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.Oils
{
    /// <summary>
    /// This class describing ingredient - olive oil
    /// </summary>
    internal class OliveOil : IIngredient
    {
        // Measured in tablespoons
        public int Quantity;
        // Olive oil price per one liter
        public double PricePerLiter = 12.4;
        // Quantity tablespoon per one liter
        public static int TablespoonPerLiter = 67;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public OliveOil(int quantity)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// Method for getting ingredient total price
        /// </summary>
        /// <returns>total price</returns>
        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerLiter / TablespoonPerLiter;
            return totalPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is OliveOil oil &&
                   Quantity == oil.Quantity &&
                   PricePerLiter == oil.PricePerLiter;
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
