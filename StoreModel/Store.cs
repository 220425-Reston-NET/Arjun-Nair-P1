namespace StoreModel
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Products> Products {get; set; } 

        public Store()
        {
            Id = 0;
            Name = "Default";
            Products = new List<Products>();
        }

    }
}