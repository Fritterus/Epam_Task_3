using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Epam_Task_3
{
    /// <summary>
    /// This class describing snack bar
    /// </summary>
    internal class SnackBar
    {
        // Ingredients list
        public List<string> Ingredients = new List<string>();
        // Dishes list
        public List<string> Dishes = new List<string>();
        // Drinks list
        public List<string> Drinks = new List<string>();

        public IEnumerable<Type> IngredientTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(IIngredient)));

        public IEnumerable<Type> DishTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(IDish)));

        public IEnumerable<Type> DrinkTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(IDrink)));

        // Dictionary menu includes dishes, drinks and prices
        public List<string> Menu = new List<string>();

        public override bool Equals(object obj)
        {
            return obj is SnackBar bar &&
                   EqualityComparer<List<string>>.Default.Equals(Ingredients, bar.Ingredients) &&
                   EqualityComparer<List<string>>.Default.Equals(Dishes, bar.Dishes) &&
                   EqualityComparer<List<string>>.Default.Equals(Drinks, bar.Drinks) &&
                   EqualityComparer<IEnumerable<Type>>.Default.Equals(IngredientTypes, bar.IngredientTypes) &&
                   EqualityComparer<IEnumerable<Type>>.Default.Equals(DishTypes, bar.DishTypes) &&
                   EqualityComparer<IEnumerable<Type>>.Default.Equals(DrinkTypes, bar.DrinkTypes) &&
                   EqualityComparer<List<string>>.Default.Equals(Menu, bar.Menu);
        }

        /// <summary>
        /// Method for getting all dishes
        /// </summary>
        public List<string> GetAllDishes()
        {
            foreach (Type item in DishTypes)
            {
                Dishes.Add(item.Name);
            }

            return Dishes;
        }

        /// <summary>
        /// Method for getting all drinks
        /// </summary>
        public List<string> GetAllDrinks()
        {
            foreach (Type item in DrinkTypes)
            {
                Drinks.Add(item.Name);
            }

            return Drinks;
        }

        /// <summary>
        /// Method for getting all ingredients
        /// </summary>
        /// <returns>list of ingredients</returns>
        public List<string> GetAllIngredients()
        {
            foreach (Type item in IngredientTypes)
            {
                Ingredients.Add(item.Name);
            }

            return Ingredients;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Ingredients, Dishes, Drinks, IngredientTypes, DishTypes, DrinkTypes, Menu);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
