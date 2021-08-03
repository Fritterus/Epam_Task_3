using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients
{
    /// <summary>
    /// This class describing ingredient - chicken fillet
    /// </summary>
    internal class ChickenFillet : IIngredient
    {
        // Measured in gram
        public int Weight;
        // Chicken fillet price per one kilogram
        public double PricePerKg = 6.7;
        // Quantity gram per one kilogram
        public static int GramPerKg = 1000;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public ChickenFillet(int weight)
        {
            Weight = weight;
        }

        /// <summary>
        /// Method for getting ingredient total price
        /// </summary>
        /// <returns>total price</returns>
        public double TotalPrice()
        {
            var totalPrice = Weight * PricePerKg / GramPerKg;
            return totalPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is ChickenFillet fillet &&
                   Weight == fillet.Weight &&
                   PricePerKg == fillet.PricePerKg;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Weight, PricePerKg);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
