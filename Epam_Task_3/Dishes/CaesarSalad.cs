using Epam_Task_3.Ingredients;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Dishes
{
    internal class CaesarSalad
    {
        public List<IIngredients> IngredientsList = new List<IIngredients>() { new Garlic(), new Tomato()};
    }
}
