using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.Others;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Drinks
{
    internal class DalgonCoffee : IDrink
    {
        /// <summary>
        /// Field list of ingredient which are necessary for this dish
        /// </summary>
        public List<IIngredient> IngredientsList = new List<IIngredient>()
        {
            new Coffee(15),
            new Sugar(12),
            new Cacao(4),
            new Water(750),
            new Milk(250),
        };

        /// <summary>
        /// Field list of coocking method
        /// </summary>
        public List<string> CoockingMethod = new List<string>()
        {
            "1. Pour water, milk and stir.",
            "2. Add coffee, sugar and cacao and stir.",
            "3. Stir until the drink is ready.",
        };

        public override bool Equals(object obj)
        {
            return obj is DalgonCoffee coffee &&
                   EqualityComparer<List<IIngredient>>.Default.Equals(IngredientsList, coffee.IngredientsList) &&
                   EqualityComparer<List<string>>.Default.Equals(CoockingMethod, coffee.CoockingMethod);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IngredientsList, CoockingMethod);
        }

        /// <summary>
        /// Method for getting drink price
        /// </summary>
        /// <returns>full price of the drnk</returns>
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
