using Epam_Task_3.Interfaces;

namespace Epam_Task_3.Ingredients
{
    /// <summary>
    /// This class describing ingredient - sesame seed
    /// </summary>
    internal class SesameSeed : IIngredient
    {
        // Measured in tablespoon
        public int Quantity;
        // Sesame seed price per one kilogram
        public double PricePerKg = 32;
        // Quantity tablespoon per one kilogram
        public static int TablespoonPerKg = 67;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public SesameSeed(int quantity)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// Method for getting ingredient total price
        /// </summary>
        /// <returns>total price</returns>
        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerKg / TablespoonPerKg;
            return totalPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is SesameSeed seed &&
                   Quantity == seed.Quantity &&
                   PricePerKg == seed.PricePerKg;
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(Quantity, PricePerKg);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
