namespace StoreModel
{
    public class Description
    {
        // Name of GPU
        // public String Name { get; set; }
        public int ID { get; set; }
        public String Brand { get; set; }
        public String GPU { get; set; }
        public String CPU { get; set; }
        public String Color { get; set; }
        public int Storage { get; set; }
        // public String Category { get; set; }



        // private int _storage;
        // public int Storage 
        // { 
        //     get { return _storage; } 
        //     set 
        //     {
        //         if (value > 200)
        //         {
        //             _storage = value;
        //         }
        //         else{
        //             Console.WriteLine("Storage space is too small!");
        //         }
        //     } 
        // }
        
        public String Category { get; set; }
    }
}