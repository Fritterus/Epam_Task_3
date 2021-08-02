using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.SaucesAndPastes;
using Epam_Task_3.Ingredients.Vegetables;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;

namespace Epam_Task_3.Dishes.MeatDishes
{
    /// <summary>
    /// This class describing dish - chicken in sauce
    /// </summary>
    internal class ChickenInSauce : IDish
    {
        /// <summary>
        /// Field list of ingredient which are necessary for this dish
        /// </summary>
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

        /// <summary>
        /// Method for getting dish price
        /// </summary>
        /// <returns>full price of the dish</returns>
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
