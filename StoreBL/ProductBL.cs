using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class ProductBL : IProductBL
    {
        private IRepository<Products> _prodRepo;
        public ProductBL(IRepository<Products> p_prodRepo)
        {
            _prodRepo = p_prodRepo;
        }

        public void AddDescriptionToProduct(Products p_product)
        {
            _prodRepo.Update(p_product);
        }

        public Products SearchProductByName(string p_prodName)
        {
            // throw new NotImplementedException();

            List<Products> currentListOfProd = _prodRepo.GetAll();

            foreach (Products prodObj in currentListOfProd)
            {
                if (prodObj.Name == p_prodName)
                {
                    return prodObj;
                }
            }

            return null;
        }

        // Create layer to grab all products from store

        // Edit DL
    }

}