// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using StoreModel;

namespace StoreDL
{
    public class DescriptionRepository : IRepository<Description>
    {
        private static string _filepath = "../StoreDL/Data/Products.json";

        public void Add(Description p_resource)
        {
            throw new NotImplementedException();
        }

        public List<Description> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Description> listOfDescription = JsonSerializer.Deserialize<List<Description>>(jsonString);
            return listOfDescription;
        }

        public void Update(Description c_resource)
        {
            throw new NotImplementedException();
        }
    }
}