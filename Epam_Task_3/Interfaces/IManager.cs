using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task_3.Interfaces
{
    internal interface IManager
    {
        public void AcceptOrder(Client client, Order order);
    }
}
