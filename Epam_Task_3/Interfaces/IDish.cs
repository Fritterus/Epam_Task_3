using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Interfaces
{
    internal interface IDish
    {
        public List<IIngredient> IngredientsList { get; }

        public void GetPrice();
    }
}
