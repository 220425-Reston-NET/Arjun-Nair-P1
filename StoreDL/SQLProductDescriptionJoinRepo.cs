using Microsoft.Data.SqlClient;
using StoreModel;

namespace StoreDL
{
    public class SQLProductDescriptionJoinRepo : IRepository<ProductDescriptionJoin>
    {

        private string _connectionString;

        public SQLProductDescriptionJoinRepo(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }

        public void Add(ProductDescriptionJoin c_resource)
        {
            throw new NotImplementedException();
        }

        public List<ProductDescriptionJoin> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductDescriptionJoin p_resource)
        {
            // throw new NotImplementedException();

            string SQLquery = @"update products_descriptions
                            set Quantity = @Quantity
                            where prodId = @prodId and descId = @descId";
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLquery, con);

                command.Parameters.AddWithValue("@Quantity", p_resource.Quantity);
                command.Parameters.AddWithValue("@prodId", p_resource.InvId);
                command.Parameters.AddWithValue("@descId", p_resource.ID);

                command.ExecuteNonQuery();
            }
        }
    }
}