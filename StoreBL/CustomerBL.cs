

using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class CustomerBL : ICustomerBL
    {

        private IRepository<Customer> _customerRepo;

        public CustomerBL(IRepository<Customer> c_customerRepo)
        {
            _customerRepo = c_customerRepo;
        }

        // public CustomerBL(IRepository<Customer> c_custRepo)
        // {
        //     _custRepo = c_custRepo;
        // }
        // Dependency 

        // private I
        public void AddCustomer(Customer c_cust)
        {
            // throw new NotImplementedException();

            Customer foundCustomer = SearchCustomerByName(c_cust.Name);
            if (foundCustomer == null)
            {
                _customerRepo.Add(c_cust);
            }
            else
            {
                throw new Exception("Customer already in Database");
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepo.GetAll();
        }

        // public List<Customer> GettAllCustomers()
        // {
        //     return _customerRepo.GetAll();
        // }

        public Customer SearchCustomerByName(string c_custName)
        {
            List<Customer> currentListOfCust = _customerRepo.GetAll();

            foreach (Customer custObj in currentListOfCust)
            {
                if (custObj.Name == c_custName)
                {
                    return custObj;
                }
            }

            return null;
        }
    }
}