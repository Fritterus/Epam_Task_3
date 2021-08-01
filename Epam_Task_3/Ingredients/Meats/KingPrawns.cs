using Epam_Task_3.Interfaces;

namespace Epam_Task_3.Ingredients.Meats
{
    internal class KingPrawns : IIngredient
    {
        // Measured in gram
        public int Quantity;
        // King prawns price per one kilogram
        public double PricePerKg = 52;
        // Quantity gram per one kilogram
        public static int GramPerKg = 1000;

        public KingPrawns(int quantity)
        {
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            var totalPrice = Quantity * PricePerKg / GramPerKg;
            return totalPrice;
        }
    }
}
