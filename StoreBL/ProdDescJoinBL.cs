using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class ProdDescJoinBL : IProdDescJoinBL
    {
        private IRepository<ProductDescriptionJoin> _prodDescRepo;
        public ProdDescJoinBL(IRepository<ProductDescriptionJoin> p_prodDescRepo)
        {
            _prodDescRepo = p_prodDescRepo;
        }

        public void RestockInventory()
        {
            throw new NotImplementedException();
        }

    }
}