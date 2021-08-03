using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Ingredients.SaucesAndPastes
{
    /// <summary>
    /// This class describing ingredient - soy sauce
    /// </summary>
    internal class SoySauce : IIngredient
    {
        // Soy Sauce is measured tablespoons
        public int Quantity;
        // Price soy sauce per one liter
        public double PricePerLiter = 9.39;
        // Quantity tablespoons in one liter
        public static int TablespoonPerLiter = 67;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public SoySauce(int quantity)
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
            return obj is SoySauce sauce &&
                   Quantity == sauce.Quantity &&
                   PricePerLiter == sauce.PricePerLiter;
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
