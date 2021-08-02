using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.Fruits;
using Epam_Task_3.Ingredients.Meats;
using Epam_Task_3.Ingredients.Oils;
using Epam_Task_3.Ingredients.Vegetables;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Dishes.Salads
{
    internal class SaladWithPrawn : IDish
    {
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
