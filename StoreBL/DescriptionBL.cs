using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class DescriptionBL : IDescriptionBL
    {
        private IRepository<Description> _descriptionRepo;
        public DescriptionBL(IRepository<Description> p_descriptionRepo)

        {
            _descriptionRepo = p_descriptionRepo;
        }

        public List<Description> GetAllDescription()
        {
            return _descriptionRepo.GetAll();
        }

        public Description SearchDescriptionByBrand(string p_descBrand)
        {
            List<Description> currentListOfDescription = _descriptionRepo.GetAll();

            foreach (Description descObj in currentListOfDescription)
            {
                if (descObj.Brand == p_descBrand)
                {
                    return descObj;
                }
            }

            return null;
        }

        // TODO: SEARCH FUNCTION
        // Search Description By Brand
        // Search Description By GPU
        // Search Description By CPU
        // Search Description By Color
        // Search Description By Size
        // Search Description By Category
    }
}