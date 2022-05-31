using Microsoft.Data.SqlClient;
using StoreModel;

namespace StoreDL
{
    public class SQLCustomerRepository : IRepository<Customer>
    {
        private string _connectionString;

        public SQLCustomerRepository(string c_connectionString)
        {
            this._connectionString = c_connectionString;
        }

        public void Add(Customer c_resource)
        {
            string SQLQuery = @"insert into Customer values (@custName, @custAddress, @custPhone, @custEmail)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@custName", c_resource.Name);
                command.Parameters.AddWithValue("@custAddress", c_resource.Address);
                command.Parameters.AddWithValue("@custPhone", c_resource.Phone);
                command.Parameters.AddWithValue("@custEmail", c_resource.Email);
                
                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAll()
        {
            // throw new NotImplementedException();

            string SQLQuery = @"select * from Customer";
            List<Customer> listOfCustomer = new List<Customer>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCustomer.Add(new Customer(){
                        CustID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Email = reader.GetString(3),
                        Phone = reader.GetString(4)
                    });
                }

                return listOfCustomer;
            }
        }

        public void Update(Customer c_resource)
        {
            throw new NotImplementedException();
        }
    }
}