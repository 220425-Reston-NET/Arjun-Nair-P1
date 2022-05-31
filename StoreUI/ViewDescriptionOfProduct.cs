using StoreBL;
using StoreModel;

namespace StoreUI
{
    public class ViewDescriptionOfProduct : IMenu
    {
        private IProdDescJoinBL _prodDescBL;

        public ViewDescriptionOfProduct(IProdDescJoinBL p_prodDescBL)
        {
            _prodDescBL = p_prodDescBL;
        }

        public void Display()
        {
            // throw new NotImplementedException();
            System.Console.WriteLine("======Specs=======");
            foreach (Description descObj in SearchProduct.foundProduct.Descriptions)
            {
                System.Console.WriteLine(descObj);
            }

            System.Console.WriteLine("[0] - Go back");
            System.Console.WriteLine("[1] - Add to Cart");
        }

        public string YourChoice()
        {
            // throw new NotImplementedException();
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                return "SearchProduct";
            }
            else if (userInput == "1")
            {
                throw new NotImplementedException();
            }
            else
            {
                return "MainMenu";
            }


        }
    }
}