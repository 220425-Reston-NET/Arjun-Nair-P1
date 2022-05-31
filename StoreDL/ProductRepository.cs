
using System.Text.Json;
using StoreModel;

namespace StoreDL
{
    public class ProductnRepository : IRepository<Products>
    {
        private static string _filepath = "../StoreDL/Data/Products.json";

        public void Add(Products p_prod)
        {
            // throw new NotImplementedException();

            List<Products> listOfProd = GetAll();
            listOfProd.Add(p_prod);

            string jsonString = JsonSerializer.Serialize(listOfProd, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }

        public List<Products> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Products> listofProduct = JsonSerializer.Deserialize<List<Products>>(jsonString);
            return listofProduct;
        }

        public void Update(Products p_resource)
        {
            // throw new NotImplementedException();

            List<Products> listOfProduct = GetAll();

            foreach (Products prodObj in listOfProduct)
            {
                if (prodObj.Name == p_resource.Name)
                {
                    prodObj.Descriptions = p_resource.Descriptions;
                }
            }

            string jsonString = JsonSerializer.Serialize(listOfProduct, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }
    }
}