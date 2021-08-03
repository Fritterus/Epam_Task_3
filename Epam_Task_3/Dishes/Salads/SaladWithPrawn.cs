using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.Fruits;
using Epam_Task_3.Ingredients.Meats;
using Epam_Task_3.Ingredients.Oils;
using Epam_Task_3.Ingredients.Vegetables;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;

namespace Epam_Task_3.Dishes.Salads
{
    /// <summary>
    /// This class describing dish - caesar salad
    /// </summary>
    internal class SaladWithPrawn : IDish
    {
        /// <summary>
        /// Field list of ingredient which are necessary for this dish
        /// </summary>
        public List<IIngredient> IngredientsList = new List<IIngredient>()
        {
            new Tomato(3),
            new KingPrawns(300),
            new GreenSalad(1),
            new Cucumber(2),
            new SesameSeed(3),
            new Lemon(1),
            new OliveOil(2),
        };

        /// <summary>
        /// Field list of coocking method
        /// </summary>
        public List<string> CoockingMethod = new List<string>()
        {
            "1. Chop the vegetables coarsely, tear the salad into pieces..",
            "2. Add shrimp.",
            "3. After boiling, cook for 5 minutes.",
            "4. Peel the shell of the shrimp.",
            "5. Mix vegetables and shrimp.",
            "6. Sprinkle with sesame seeds and season with mayonnaise."
        };

        public override bool Equals(object obj)
        {
            return obj is SaladWithPrawn prawn &&
                   EqualityComparer<List<IIngredient>>.Default.Equals(IngredientsList, prawn.IngredientsList) &&
                   EqualityComparer<List<string>>.Default.Equals(CoockingMethod, prawn.CoockingMethod);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IngredientsList, CoockingMethod);
        }

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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
