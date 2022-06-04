using StoreModel;

namespace StoreBL
{
    public interface IProductBL
    {
        // TODO
        // Search function

        // void AddProduct(Products p_prod);

        Products SearchProductByName(string p_prodName);

        void AddDescriptionToProduct(Products p_product);

        List<Products> GetAllProducts();
    }
}