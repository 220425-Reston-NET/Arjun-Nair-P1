using Microsoft.Data.SqlClient;
using StoreModel;

namespace StoreDL
{
    public class SQLProductRepository : IRepository<Products>
    {
        private string _connectionString;

        public SQLProductRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }

        public void Add(Products p_resource)
        {
            string SqlQuery = @"insert into Products
                                values (@prodName, @prodPrice";
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SqlQuery, con);

                command.Parameters.AddWithValue("@prodName", p_resource.Name);
                command.Parameters.AddWithValue("@prodPrice", p_resource.Price);

                command.ExecuteNonQuery();
            }
        }

        public List<Products> GetAll()
        {
            string SqlQuery =  @"select * from Products";
            List<Products> listOfProducts = new List<Products>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfProducts.Add(new Products(){
                        InvID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetInt32(2),
                        // Descriptions = GiveDescriptionToProduct(reader.GetInt32(0))
                    });
                }

                    // listOfProducts.All<Products>{
                    //     InvID = reader.GetInt32(0),
                    //     Name = reader.GetString(1),
                    //     Price = reader.GetInt32(2),
                    //     Descriptions = GiveDescriptionsToProduct(reader.GetInt32(0))
                    // };


                return listOfProducts;
            }
        }

        

        // COMMENT OUT DESCRIPTION CONNECTION - CAUSE OF SQL PROBLEMS



        private List<Description> GiveDescriptionToProduct(int p_InvId)
        {
            string SQLQuery = @"select p.prodName, d.descCategory, p.prodPrice, pd.Quantity from Products p
                inner join products_descriptions pd on p.prodId = pd.prodId
                inner join Descriptions d on d.descId = pd.descId
                where p.prodId = @prodId";

            List<Description> listOfDescription = new List<Description>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@prodId", p_InvId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfDescription.Add(new Description(){
                        ID = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        GPU = reader.GetString(3),
                        CPU = reader.GetString(2),
                        Color = reader.GetString(5),
                        Storage = reader.GetInt32(4),
                        Category = reader.GetString(6)
                        
                    });
                }
            }

            return listOfDescription;
        }

        public void Update(Products c_resource)
        {
            throw new NotImplementedException();
        }

        private List<Description> GiveDescriptionsToProduct(int p_InvId)
        {
            return null;
            // string Sqlquery = @"select p.prodName, d.descName, pd."
        }
    }
}