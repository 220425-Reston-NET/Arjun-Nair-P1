
using Microsoft.Data.SqlClient;
using StoreBL;
using StoreModel;

public class ProductInventory : IMenu
{

    private IProductBL _prodBL;

    public ProductInventory(IProductBL p_prodBL)
    {
        _prodBL = p_prodBL;
    }

    public void Display()
    {
        System.Console.WriteLine("All Available Products");
        // using (SqlConnection con = new p_connectionString)
        // {


        // }

        // SqlParameter p_InvId = new SqlParameter("@prodId", System.Data.SqlDbType.Int);

        // p_InvId.Value = Parameters.Add(p_InvId);

        // foreach (Product prodObj in SearchProduct.foundProduct.Product)
        // {
        //     System.Console.WriteLine(prodObj);
        // }
        // System.Console.WriteLine("[0] MainMenu");
        // System.Console.WriteLine("ID || Name - Price");


        System.Console.WriteLine("[0] MainMenu");
        System.Console.WriteLine("[1] || Name - Price");
        
    }

    public string YourChoice()
    {
        throw new NotImplementedException();
    }

    // public class YourChoice()
    // {
    //     string userInput = Console.ReadLine();

    //     if (userInput == "0")
    //     {
    //         return "MainMenu";
    //     }
    // }
}