using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Epam_Task_3
{
    internal class Order
    {
        private static int _nextId;
        public int Id { get; private set; }
        public double Cost;
        public IDish Dish;

        public Order(IDish dish)
        {
            Dish = dish;
            Id = Interlocked.Increment(ref _nextId);
        }


    }
}
