

using StoreBL;
using StoreModel;

public class AddCustomer : IMenu
{
    private Customer custObj = new Customer();

    private ICustomerBL _custBL;

    public AddCustomer(ICustomerBL c_custBL)
    {
        _custBL = c_custBL;
    }

    public void Display()
    {
        System.Console.WriteLine("Please enter your details:");
        System.Console.WriteLine("What is your full name?");
        custObj.Name = Console.ReadLine();
        System.Console.WriteLine("What is your address?");
        custObj.Address = Console.ReadLine();
        System.Console.WriteLine("What is your Email?");
        custObj.Email = Console.ReadLine();
        System.Console.WriteLine("What is your Phone Number?");
        custObj.Phone = Console.ReadLine();

        Console.WriteLine("What is your ID?");
        try
        {
            custObj.CustID = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception)
        {
            
            System.Console.WriteLine("Warning: CustID cannot be negative!");
            custObj.CustID = 1;
        }

        System.Console.WriteLine("[1] - Add Customer Info");
        System.Console.WriteLine("[2] - Exit");
    }

    public string YourChoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            _custBL.AddCustomer(custObj);
            return "MainMenu";
        }
        else
        {
            return "AddCustomer";
        }
        
        

    }
}