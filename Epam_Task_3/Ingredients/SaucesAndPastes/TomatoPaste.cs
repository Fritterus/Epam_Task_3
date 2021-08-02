using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.SaucesAndPastes
{
    /// <summary>
    /// This class describing ingredient - tomato paste
    /// </summary>
    internal class TomatoPaste : IIngredient
    {
        // Measured in tablespoons
        public int Quantity;
        // Tomato paste price per one liter
        public double PricePerLiter = 9.3;
        // Quantity tablespoon per one liter
        public static int TablespoonPerLiter = 67;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public TomatoPaste(int quantity)
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
    }
}
