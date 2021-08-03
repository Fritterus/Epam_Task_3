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
        public string Status;
        public double Cost;
        public IDish Dish;
        public IDrink Drink;

        public Order(IDish dish, IDrink drink)
        {
            Dish = dish;
            Drink = drink;
            Id = Interlocked.Increment(ref _nextId);
            Status = "Awaiting";
            Cost = dish.GetPrice() + drink.GetPrice();
        }
    }
}
