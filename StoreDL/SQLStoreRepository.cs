using Microsoft.Data.SqlClient;
using StoreModel;

namespace StoreDL
{
    // public class SQLStoreRepository : IRepository<Store>
    // {
    //     private string _connectionString;
        
    //     public SQLStoreRepository(string p_connnectionString)
    //     {
    //         this._connectionString = p_connnectionString;
    //     }
    //     public void Add(Store p_resource)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public List<Store> GetAll()
    //     {
    //         // throw new NotImplementedException();
    //         string SqlQuery = @"select * from Store";
    //         List<Store> listOfCurrentStore = new List<Store>();

    //         using (SqlConnection con = new SqlConnection(_connectionString))
    //         {
    //             con.Open();

    //             SqlCommand command = new SqlCommand(SqlQuery, con);

    //             SqlDataReader reader = command.ExecuteReader();

    //             while (reader.Read())
    //             {
    //                 listOfCurrentStore.Add(new Store(){
    //                     Id = reader.GetInt32(0),
    //                     Name = reader.GetString(1),
    //                     Products = GetProductsFromAStore(reader.GetInt32(0))
    //                 });
    //             }
    //         }

    //         return listOfCurrentStore;

    //     }

    //     private List<Products> GetProductsFromAStore(int p_sId)
    //     {
    //         string SqlQuery = @"select s.storeName, i.Quantity, p.prodId, p.prodName from Store s
    //                             inner join Inventory i on s.storeId = i,storeId
    //                             inner join Product p on i.prodId = p.prodId
    //                             where s.storeId = @storeId";

    //         List<Products> listOfCurrentProduct = new List<Products>();

    //         using (SqlConnection con = new SqlConnection(_connectionString))
    //         {
    //             con.Open();

    //             SqlCommand command  = new SqlCommand(SqlQuery, con);

    //             command.Parameters.AddWithValue("@storeId", p_sId);

    //             SqlDataReader reader = command.ExecuteReader();

    //             while (reader.Read())
    //             {
    //                 listOfCurrentProduct.Add(new Products(){
    //                     InvID = reader.GetInt32(2),
    //                     Name = reader.GetString(3)
    //                     // Quantity = reader.GetInt32(1)
    //                 });
    //             }
    //         }

    //         return listOfCurrentProduct;
    //     }

    //     public Task<List<Store>> GetAllAsync()
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public void Update(Store c_resource)
    //     {
    //         throw new NotImplementedException();
    //     }
    // }
}