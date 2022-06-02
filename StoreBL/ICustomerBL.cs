

using StoreModel;

namespace StoreBL
{
    public interface ICustomerBL
    {
        /// <summary>
        /// Add Customer to the DB and make them readonly
        /// </summary>
        /// <param name="c_cust"></param>
        void AddCustomer(Customer c_cust);

        Customer SearchCustomerByName(string c_custName);

        List<Customer> GetAllCustomers();

    }
}