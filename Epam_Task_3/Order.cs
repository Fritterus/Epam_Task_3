using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Epam_Task_3
{
    /// <summary>
    /// This class describing order
    /// </summary>
    internal class Order
    {
        // Id counter
        private static int _nextId;
        // Order Id
        public int Id { get; private set; }
        public string Status;
        public double Cost;
        public int ClientId;
        public IDish Dish;
        public IDrink Drink;

        /// <summary>
        /// Constructor for initializes order parameter
        /// </summary>
        /// <param name="dish">dish</param>
        /// <param name="drink">drink</param>
        /// <param name="clientId">client id</param>
        public Order(IDish dish, IDrink drink, int clientId)
        {
            Dish = dish;
            Drink = drink;
            ClientId = clientId;
            Id = Interlocked.Increment(ref _nextId);
            Status = "Awaiting";
            Cost = dish.GetPrice() + drink.GetPrice();
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   Id == order.Id &&
                   Status == order.Status &&
                   Cost == order.Cost &&
                   ClientId == order.ClientId &&
                   EqualityComparer<IDish>.Default.Equals(Dish, order.Dish) &&
                   EqualityComparer<IDrink>.Default.Equals(Drink, order.Drink);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Status, Cost, ClientId, Dish, Drink);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
