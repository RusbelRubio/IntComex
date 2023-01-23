using ApiBackEnd_Customers.Interfaces;

namespace ApiBackEnd_Customers.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _contextDB;
        public CustomerRepository(DataContext context)
        {
            _contextDB = context;
        }
        public DataContext DataBase { get => _contextDB; }

        public Task<Customer> GetCustomers(string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
