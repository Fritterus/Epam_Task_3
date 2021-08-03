namespace Epam_Task_3.Interfaces
{
    internal interface IClient
    {
        public Order MakeOrder(IDish dish,  IDrink drink, int id);
    }
}
