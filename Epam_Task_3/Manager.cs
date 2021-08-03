using Epam_Task_3.Dishes.MeatDishes;
using Epam_Task_3.Dishes.Salads;
using Epam_Task_3.Drinks;
using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Task_3
{
    /// <summary>
    /// This class describing manager
    /// </summary>
    internal class Manager : IManager
    {
        private SnackBar _snackBar = new SnackBar();

        /// <summary>
        /// Method for make menu
        /// </summary>
        public void MakeMenu()
        {
            foreach (var item in _snackBar.GetAllDishes().Concat(_snackBar.GetAllDrinks()).ToList())
            {
                _snackBar.Menu.Add(item.GetType().Name);
            }
        }

        /// <summary>
        /// Method for changing status of order
        /// </summary>
        /// <param name="order">order</param>
        public void AcceptOrder(Order order)
        {
            order.Status = "Accept";
        }

        public override bool Equals(object obj)
        {
            return obj is Manager manager &&
                   EqualityComparer<SnackBar>.Default.Equals(_snackBar, manager._snackBar);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_snackBar);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
