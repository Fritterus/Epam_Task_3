using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.Vegetables;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;

namespace Epam_Task_3.Dishes.Salads
{
    /// <summary>
    /// This class describing dish - caesar salad
    /// </summary>
    internal class CaesarSalad : IDish
    {
        /// <summary>
        /// Field list of ingredient which are necessary for this dish
        /// </summary>
        public List<IIngredient> IngredientsList = new List<IIngredient>()
        {
            new ChickenFillet(300),
            new Garlic(2),
            new GreenSalad(1),
            new Tomato(1),
            new WhiteBread(6),
        };

        /// <summary>
        /// Field list of coocking method
        /// </summary>
        public List<string> CoockingMethod = new List<string>()
        {
            "1. Wash, dry and cut the lettuce leaves into small pieces.",
            "2. Put 1 tablespoon of butter in a hot skillet.",
            "3. Cut the chicken breast into approximately 1x3 cm pieces.",
            "4. Put in a frying pan with garlic and butter.",
            "5. Fry over high heat for about 10 minutes until golden brown.",
            "6. Get the lettuce leaves, put the fried chicken breast there."
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
