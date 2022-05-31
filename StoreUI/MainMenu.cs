using StoreModel;
namespace StoreUI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Store terminal.");
            Console.WriteLine("Please select an option.");
            System.Console.WriteLine("[0] - Add Customer");
            System.Console.WriteLine("[1] - Search Customer");
            System.Console.WriteLine("[2] - Check Products");
            System.Console.WriteLine("[3] - Shopping Cart");
            System.Console.WriteLine("[4] - Exit");
        }

        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                return "AddCustomer";
            }
            else if (userInput == "1")
            {
                // Console.Clear();
                return "SearchCustomer";
            }
            else if (userInput == "2")
            {
                // Console.Clear();
                return "SearchProduct";
            }
            else if (userInput == "3")
            {
                return "Order";
            }
            else if (userInput == "4")
            {
                return "Exit";
            }
            else
            {
                System.Console.WriteLine("Please input ");
                return "MainMenu";
            }
        }
    }
}