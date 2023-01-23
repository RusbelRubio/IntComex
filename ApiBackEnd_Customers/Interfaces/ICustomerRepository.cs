namespace ApiBackEnd_Customers.Interfaces
{
    public interface ICustomerRepository
    {
        DataContext DataBase
        {
            get;
        }
        Task<Customer> GetCustomers(string UserId);
    }
}
