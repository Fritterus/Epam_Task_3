using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.SaucesAndPastes;
using Epam_Task_3.Ingredients.Vegetables;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;

namespace Epam_Task_3.Dishes.MeatDishes
{
    internal class ChickenInSauce : IDish
    {
        public List<IIngredient> IngredientsList = new List<IIngredient>()
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

        public double GetPrice()
        {
            double price = 0;

            foreach (var item in IngredientsList)
            {
                if (item.TotalPrice() == 0)
                {
                    throw new Exception("Price of this ingredient has not been set");
                }
                else
                {
                    price += item.TotalPrice();
                }
                
            }

            return Math.Round(price, 2);
        }
    }
}
