using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients
{
    /// <summary>
    /// This class describing ingredient - sugar
    /// </summary>
    internal class Sugar : IIngredient
    {
        // Sugar is measured in teaspoons
        public int Quantity;
        // Sugar price per one kilogram
        public double PricePerKg = 1.69;
        // Quantity teaspoon in one kilogram of sugar
        public static int TeaspoonPerKg = 143;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public Sugar(int quantity)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// Method for getting ingredient total price
        /// </summary>
        /// <returns>total price</returns>
        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerKg / TeaspoonPerKg;
            return totalPrice;
        }
    }
}
