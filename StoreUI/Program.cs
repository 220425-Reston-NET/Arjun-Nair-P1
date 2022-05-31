// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
global using Serilog;
using Microsoft.Extensions.Configuration;
using StoreBL;
using StoreDL;
using StoreModel;
using StoreUI;

// Products invObj = new Products();
// invObj.InvID = 1;

// System.Console.WriteLine(invObj.InvID);
// System.Console.WriteLine(invObj.Name);
// System.Console.WriteLine(invObj.Price);

// System.Console.WriteLine(invObj.InvID[], invObj.Name[0], invObj.Category[0]);
// Products invObject = new Products.Products();

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt")
    .CreateLogger();

var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

IMenu  menu = new MainMenu();
bool repeat = true;

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.YourChoice();

    if (ans == "MainMenu")
    {
        menu = new MainMenu();
    } 
    else if (ans == "AddCustomer") 
    {
        Log.Information("User creating their AddCustomer profile");
        menu = new AddCustomer(
            new CustomerBL(new SQLCustomerRepository(configuration.GetConnectionString("Arjun_Nair")))
        );
    }
    else if (ans == "SearchProduct") 
    {
        Log.Information("User searching for products");
        menu = new SearchProduct(
            new ProductBL(new SQLProductRepository(configuration.GetConnectionString("Arjun_Nair")))
        );
    }
    else if (ans == "SearchCustomer") 
    {
        Log.Information("User searching for customer");
        menu = new SearchCustomer(
            new CustomerBL(new SQLCustomerRepository(configuration.GetConnectionString("Arjun_Nair")))
        );
    }
    else if (ans == "Order")
    {
        Log.Information("User entering shopping cart");
    }
    else if (ans == "Exit") 
    {
        repeat = false;
    }

}