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

        public override bool Equals(object obj)
        {
            return obj is Dish dish &&
                   _name == dish._name &&
                   EqualityComparer<List<IIngredient>>.Default.Equals(_ingredientsList, dish._ingredientsList) &&
                   EqualityComparer<List<string>>.Default.Equals(_coockingMethod, dish._coockingMethod);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_name, _ingredientsList, _coockingMethod);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
