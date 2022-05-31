using StoreBL;
using StoreModel;

public class SearchProduct : IMenu
{
    public static Products foundProduct;

    private IProductBL _prodBL;

    public SearchProduct(IProductBL p_prodBL)
    {
        _prodBL = p_prodBL;
    }

public void Display()
    {
        // throw new NotImplementedException();

        System.Console.WriteLine("Search for your product: ");
        System.Console.WriteLine("[0] - Go Back");
        System.Console.WriteLine("[1] - Search ny Name");
        System.Console.WriteLine("[2] - Search ny Price");
        System.Console.WriteLine("[3] - Search ny ID");
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
            System.Console.WriteLine("Enter the product name:");
            string prodName = Console.ReadLine();

            foundProduct = _prodBL.SearchProductByName(prodName);

            if (foundProduct == null)
            {
                System.Console.WriteLine("Product not found. Either name was typed incorrectly or product was never in stock.");
            }
            else
            {
                System.Console.WriteLine(foundProduct.ToString());

                System.Console.WriteLine("[2] - View Specs");
                System.Console.WriteLine("[1] - Purchase");
                System.Console.WriteLine("[0] - Go Back");
                string addProdChoice = Console.ReadLine();
                if (addProdChoice == "2")
                {
                    return "ViewDescriptionOfProduct";
                }
                else if (addProdChoice == "1")
                {
                    throw new NotImplementedException();
                }
                else
                {
                    return "SelectProduct";
                }
            }

            Console.ReadLine();
            return "SearchProduct";
        }
        else if (userInput == "2")
        {
            throw new NotImplementedException();
        }
        else if (userInput == "3")
        {
            throw new NotImplementedException();
        }
        else
        {
            System.Console.WriteLine("Please choose an option listed!");
            return "SearchProduct";
        }
    }
}