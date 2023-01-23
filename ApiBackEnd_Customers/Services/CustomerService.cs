#nullable disable
using ApiBackEnd_Customers.Exceptions;
using ApiBackEnd_Customers.Interfaces;

namespace ApiBackEnd_Customers.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            this._repository = repository;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _repository.DataBase.Customers.ToListAsync();
        }

        public async Task<Customer> InsertCustomer(Customer customer)
        {
            var user = await this.GetByUserId(customer.User);
            if (user != null)
            {
                throw new BusinessException("User exist");
            }
            await _repository.DataBase.Customers.AddAsync(customer);
            await _repository.DataBase.SaveChangesAsync();
            user = await this.GetByUserId(customer.User);
            return user;
        }
        private async Task<Customer> GetByUserId(string UserId)
        {
            if (await _repository.DataBase.Customers.CountAsync() > 0)
            {
                var customerfound = await _repository.DataBase.Customers.Where(x => x.User.ToLower() == UserId.ToLower()).ToListAsync();
                return customerfound?.FirstOrDefault();
            }
            else
                return null;
        }
    }
}
