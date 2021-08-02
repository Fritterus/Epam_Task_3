using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.Vegetables;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;

namespace Epam_Task_3.Dishes.Salads
{
    internal class CaesarSalad : IDish
    {
        public List<IIngredient> IngredientsList = new List<IIngredient>()
        {
            new ChickenFillet(300),
            new Garlic(2),
            new GreenSalad(1),
            new Tomato(1),
            new WhiteBread(6),
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
