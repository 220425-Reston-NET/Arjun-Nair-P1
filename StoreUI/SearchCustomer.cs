
using StoreBL;
using StoreModel;

public class SearchCustomer : IMenu
{
    public static Customer foundCustomer;
    
    private ICustomerBL _custBL;
    public SearchCustomer(ICustomerBL c_custBL)
    {
        _custBL = c_custBL;
    }

    public void Display()
    {
        // throw new NotImplementedException();
        System.Console.WriteLine("Search for a customer: ");
        System.Console.WriteLine("[0] - Go Back");
        System.Console.WriteLine("[1] - Search by Name");
        System.Console.WriteLine("[2] - Search by Email");
        System.Console.WriteLine("[3] - Search by ID");
    }

    public string YourChoice()
    {
        // throw new NotImplementedException();

        string userInput = Console.ReadLine();

        if (userInput == "0")
        {
            return "MainMenu";
        }
        else if (userInput == "1")
        {
            System.Console.WriteLine("Enter customer name: ");
            string custName = Console.ReadLine();

            foundCustomer = _custBL.SearchCustomerByName(custName);

            if (foundCustomer == null)
            {
                System.Console.WriteLine("Customer was not found!");
            }
            else
            {
                System.Console.WriteLine(foundCustomer.ToString());

                System.Console.WriteLine("[0] - Go Back");
                System.Console.WriteLine("[1] - Main Menu");

                string addCustChoice = Console.ReadLine();
                if (addCustChoice == "1")
                {
                    return "MainMenu";
                }
                else
                {
                    return "SearchCustomer";
                }
            }

            Console.ReadLine();
            return "SearchCustomer";
        }
        else if (userInput == "2")
        {
            System.Console.WriteLine("Enter customer Id: ");
            string custId = Console.ReadLine();

            foundCustomer = _custBL.SearchCustomerByName(custId);

            if (foundCustomer == null)
            {
                System.Console.WriteLine("Customer was not found!");
            }
            else
            {
                System.Console.WriteLine(foundCustomer.ToString());

                System.Console.WriteLine("[0] - Go Back");
                System.Console.WriteLine("[1] - Main Menu");

                string addCustChoice = Console.ReadLine();
                if (addCustChoice == "1")
                {
                    return "MainMenu";
                }
                else
                {
                    return "SearchCustomer";
                }
            }

            return "MainMenu";
        }
        else if (userInput == "3")
        {
            return "MainMenu";
        }
        else
        {
            System.Console.WriteLine("Please enter a valid response");
            return "SearchCustomer";
        }
    }

    
}