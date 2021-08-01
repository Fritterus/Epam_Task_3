using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.SaucesAndPastes;
using Epam_Task_3.Ingredients.Vegetables;
using Epam_Task_3.Interfaces;
using System.Collections.Generic;

namespace Epam_Task_3.Dishes.MeatDishes
{
    internal class ChickenInSauce : IDish
    {
        public double Price;

        public List<IIngredient> IngredientsList => new List<IIngredient>()
        {
            new ChickenFillet(500),
            new SoySauce(10),
            new AppleVinegar(40),
            new Sugar(5),
            new TomatoPaste(2),
            new BellPepper(1),
            new Pineapple(1),
            new Tomato(2),
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
