namespace ApiBackEnd_Customers.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> InsertCustomer(Customer customer);
    }
}
