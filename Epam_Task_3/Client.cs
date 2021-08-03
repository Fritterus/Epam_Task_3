using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Epam_Task_3
{
    /// <summary>
    /// This class describing client of snack bar
    /// </summary>
    internal class Client : IClient
    {
        private static readonly SnackBar _snackBar = new SnackBar();
        // Id counter
        private static int _nextId;
        // Client Id
        public int Id { get; private set; }

        /// <summary>
        /// Constructor for initializes client parameter
        /// </summary>
        public Client()
        {
            Id = Interlocked.Increment(ref _nextId);
        }

        /// <summary>
        /// Method for viewing a menu
        /// </summary>
        /// <returns>Menu</returns>
        public List<string> ViewMenu()
        {
            if (_snackBar.Menu.Count != 0)
            {
                return _snackBar.Menu;
            }
            else
            {
                throw new Exception("Menu not compiled yet");
            }
        }

        /// <summary>
        /// Method for make order
        /// </summary>
        /// <param name="dish">dish</param>
        /// <param name="drink">drink</param>
        /// <param name="id">client id</param>
        /// <returns>order</returns>
        public Order MakeOrder(IDish dish, IDrink drink, int id)
        {
            var order = new Order(dish, drink, id);
            return order;
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   Id == client.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
