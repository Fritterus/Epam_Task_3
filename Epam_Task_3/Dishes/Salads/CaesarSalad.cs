using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.Vegetables;
using Epam_Task_3.Interfaces;
using System.Collections.Generic;

namespace Epam_Task_3.Dishes.Salads
{
    internal class CaesarSalad : IDish
    {
        public double Price;

        public List<IIngredient> IngredientsList => new List<IIngredient>()
        {
            new ChickenFillet(300),
            new Garlic(2),
            new GreenSalad(1),
            new Tomato(1),
            new WhiteBread(6),
        };

        public void GetPrice()
        {
            foreach (var item in IngredientsList)
            {
                Price += item.TotalPrice();
            }
        }
    }
}
