using Epam_Task_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3
{
    internal class Manager : IManager
    {
        public void AcceptOrder(Order order)
        {
            order.Status = "Accept";
        }
    }
}
