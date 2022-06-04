using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StoreBL;
using StoreModel;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private IProductBL _productBL;

        public ProductController(IProductBL productBL)
        {
            _productBL = productBL;
        }

        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            try
            {
                List<Products> listOfCurrentProducts = _productBL.GetAllProducts();

                return Ok(listOfCurrentProducts);
            }
            catch (SqlException)
            {
                
                return NotFound("We Do Not Sell This Product!");
            }
        }
    }
}