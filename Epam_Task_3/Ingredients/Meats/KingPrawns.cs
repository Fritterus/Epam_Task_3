using Epam_Task_3.Interfaces;

namespace Epam_Task_3.Ingredients.Meats
{
    /// <summary>
    /// This class describing ingredient - king prawns
    /// </summary>
    internal class KingPrawns : IIngredient
    {
        // Measured in gram
        public int Quantity;
        // King prawns price per one kilogram
        public double PricePerKg = 52;
        // Quantity gram per one kilogram
        public static int GramPerKg = 1000;

        /// <summary>
        /// Constructor for initialize ingredient quantity
        /// </summary>
        /// <param name="quantity">ingredient quantity</param>
        public KingPrawns(int quantity)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// Method for getting ingredient total price
        /// </summary>
        /// <returns>total price</returns>
        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerKg / GramPerKg;
            return totalPrice;
        }
    }
}
