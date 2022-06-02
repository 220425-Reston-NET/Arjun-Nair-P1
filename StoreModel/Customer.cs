using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace StoreModel
{
    public class Customer
    {

        private int _custId;

        public int CustID 
        { 
            get {return _custId; } 
            set 
            {
                if (value > 0)
                {
                    _custId = value;
                }
                else
                {
                    throw new ValidationException("Customer ID can only hold positive numbers!");
                }
            }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        // private string Email { get; set; }
        public string Phone { get; set; }

        private string _email { get; set; }
        public string Email 
        { 
            get {return _email; }
            set
            {
                try
                {
                    // MailAddress m = new MailAddress(value);

                    _email = value;
                }
                catch (FormatException)
                {
                    
                    throw new ValidationException("This is not a valid email");
                }
                _email = value;
            }

            
        }

        public List<Order> Orders {get; set;}

        public Customer()
        {
            CustID = 1;
            Name = "John Jones";
            Address = "Sample Address";
            Phone = "555-555-5555";
            Email = "sample.example@email.com";
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            return $"===Customer Info===\nName:  {Name}\nAddress: {Address} \nPhone:  {Phone}\nEmail:  {Email}\n==============";
        }
    }
}