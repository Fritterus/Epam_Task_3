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
            return _snackBar.Menu;
        }

        public Order MakeOrder(IDish dish)
        {
            var order = new Order(dish);
            return order;
        }
    }
}
