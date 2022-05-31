namespace StoreModel
{
    public class Order 
    {
        public string ItemName { get; set; }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set 
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    Console.WriteLine("Quantity cannot be below zero.");
                }
            }
        }
        public int Price { get; set; }   
    }
}