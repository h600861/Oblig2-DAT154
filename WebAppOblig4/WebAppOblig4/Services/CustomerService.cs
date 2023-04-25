using WebAppOblig4.Models;
namespace WebAppOblig4.Services

{
    public interface ICustomerService
    {
        //public Customer GetCustomerByEmail (string email);
        public bool ValidCustomer (Customer customer);

       // public void AddCustomer (Customer customer);
    }
    public class CustomerService : ICustomerService
    {
       
    public bool ValidCustomer(Customer customer)
        {
            if (customer == null || customer.Email == null || customer.Password == null || customer.Name == null)
            {
                return false;
            }

            return true;
        }
    }
}
