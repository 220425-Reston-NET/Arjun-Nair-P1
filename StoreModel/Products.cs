// See https://aka.ms/new-console-template for more information
// System.Console.WriteLine("Hello, World!");

namespace StoreModel
{
    public class Products
    {
        private int _invID;
        public int InvID 
        { 
            get { return _invID; }  
            set {
                if (value > 0)
                {
                    _invID = value;
                }
                else
                {
                    Console.WriteLine("Products ID can only hold positive numbers!");
                }
            }
        }

        public string Name { get; set; }
        public int Price { get; set; }

        public List<Description> Descriptions {get; set;}

        public Products()
        {
            InvID = 1;
            Name = "MSI GF63";
            Price = 500;
            // Descriptions = new List<Description>();
        }

        public override string ToString()
        {
            return $"===Product Info===\nName:  {Name}\nPrice:  {Price}\n=====================";
        }
        
    }
    
}