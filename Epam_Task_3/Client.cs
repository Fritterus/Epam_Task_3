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
        private static int _nextId;
        public int Id { get; private set; }

        public Client()
        {
            Id = Interlocked.Increment(ref _nextId);
        }

        public Dictionary<string, double> ViewMenu()
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

        public Order MakeOrder(IDish dish, IDrink drink)
        {
            var order = new Order(dish, drink);
            return order;
        }
    }
}
