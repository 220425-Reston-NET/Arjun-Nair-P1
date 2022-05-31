using System.Text.Json;
using StoreModel;

namespace StoreDL
{
    public class CustomerRepository : IRepository<Customer>
    {

        private string _filepath = "../StoreDL/Data/Customer.json";

        public void Add(Customer c_resource)
        {
            // throw new NotImplementedException();
            List<Customer> listOfCust = GetAll();
            listOfCust.Add(c_resource);

            string jsonString = JsonSerializer.Serialize(listOfCust, new JsonSerializerOptions{WriteIndented = true});
        }

        public List<Customer> GetAll()
        {
            // throw new NotImplementedException();
            string jsonString = File.ReadAllText(_filepath);
            List<Customer> listOfCustomers = JsonSerializer.Deserialize<List<Customer>>(jsonString);

            return listOfCustomers;
        }

        public void Update(Customer c_resource)
        {
            throw new NotImplementedException();

        // string jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions{WriteIndented = true});
        // File.WriteAllText(_filepath, jsonString);
        }

        
    }
}