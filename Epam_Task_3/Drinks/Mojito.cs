using Epam_Task_3.Ingredients;
using Epam_Task_3.Ingredients.Fruits;
using Epam_Task_3.Ingredients.Others;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Drinks
{
    /// <summary>
    /// This class describing drink - mojito
    /// </summary>
    internal class Mojito : IDrink
    {
        /// <summary>
        /// Field list of ingredient which are necessary for this dish
        /// </summary>
        public List<IIngredient> IngredientsList = new List<IIngredient>()
        {
            new Lime(2),
            new Sugar(5),
            new FreshMite(4),
            new Water(1000),
        };

        /// <summary>
        /// Field list of coocking method
        /// </summary>
        public List<string> CoockingMethod = new List<string>()
        {
            "1. Slice lime.",
            "2. Add lime pieces to the glass.",
            "3. Cover with water, add sugar and stir.",
            "4. Add fresh mite.",
        };

        public override bool Equals(object obj)
        {
            return obj is Mojito mojito &&
                   EqualityComparer<List<IIngredient>>.Default.Equals(IngredientsList, mojito.IngredientsList) &&
                   EqualityComparer<List<string>>.Default.Equals(CoockingMethod, mojito.CoockingMethod);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IngredientsList, CoockingMethod);
        }

        /// <summary>
        /// Method for getting drink price
        /// </summary>
        /// <returns>full price of the drink</returns>
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
