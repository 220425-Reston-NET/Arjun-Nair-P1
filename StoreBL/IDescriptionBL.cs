using StoreModel;

namespace StoreBL
{
    public interface IDescriptionBL
    {
        List<Description> GetAllDescription();

        Description SearchDescriptionByBrand(string p_descBrand);

        // TODO: SEARCH FUNCTION
        // Search Description By Brand
        // Search Description By GPU
        // Search Description By CPU
        // Search Description By Color
        // Search Description By Size
        // Search Description By Category
    }
}