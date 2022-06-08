// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using StoreBL;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace PokeApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class StoreController : ControllerBase
//     {

//         private IStoresBL _storeBL;
//         public StoreController(IStoresBL p_StoreBL)
//         {
//             _storeBL = p_StoreBL;
//         }
//         [HttpGet("ViewStoreInventory")]
//         public IActionResult ViewStoreInventory([FromQuery] int p_sId)
//         {
//             return Ok(_storeBL.ViewStoreInventory(p_sId));
//         }
//     }
// }