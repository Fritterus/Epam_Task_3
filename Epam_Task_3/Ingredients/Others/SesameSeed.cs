using Epam_Task_3.Interfaces;

namespace Epam_Task_3.Ingredients
{
    internal class SesameSeed : IIngredient
    {
        // Measured in tablespoon
        public int Quantity;
        // Sesame seed price per one kilogram
        public double PricePerKg = 32;
        // Quantity tablespoon per one kilogram
        public static int TablespoonPerKg = 67;

        public SesameSeed(int quantity)
        {
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerKg / TablespoonPerKg;
            return totalPrice;
        }
    }
}
