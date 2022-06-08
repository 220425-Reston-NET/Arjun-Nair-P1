using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class StoresBL : IStoresBL
    {
        private IRepository<Store> _storeRepo;
        public StoresBL(IRepository<Store> p_storeRepo)
        {
            _storeRepo = p_storeRepo;
        }
        public List<Products> ViewStoreInventory(int p_sId)
        {
            List<Store> listOfCurrentStore = _storeRepo.GetAll();

            foreach (Store item in listOfCurrentStore)
            {
                if (item.Id == p_sId)
                {
                    return item.Products;
                }
                // throw new NotImplementedException();
            }

            return null;
            
        }
    }
}