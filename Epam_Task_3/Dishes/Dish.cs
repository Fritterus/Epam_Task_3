using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;

namespace Epam_Task_3.Dishes
{
    /// <summary>
    /// This class describing any dish
    /// </summary>
    internal class Dish
    {
        private readonly string _name;
        private readonly List<IIngredient> _ingredientsList = new List<IIngredient>();
        private readonly List<string> _coockingMethod = new List<string>();

        public Dish(string name, List<IIngredient> ingredientsList, List<string> coockingMethod)
        {
            _name = name;
            _ingredientsList = ingredientsList;
            _coockingMethod = coockingMethod;
        }
    }
}
