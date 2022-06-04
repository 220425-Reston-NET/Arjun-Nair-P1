using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StoreBL;
using StoreModel;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : ControllerBase
    {

        private ICustomerBL _customerBL;

        public CustomerController(ICustomerBL customerBL)
        {
            _customerBL = customerBL;
        }
        
        [HttpGet("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {
            try
            {
                List<Customer> listOfCurrentCustomer = _customerBL.GetAllCustomers();

                return Ok(listOfCurrentCustomer);
            }
            catch (SqlException)
            {
                
                return NotFound("No Customers Exist");
            }
        }

        [HttpGet("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer c_customer)
        {
            try
            {
                _customerBL.AddCustomer(c_customer);

                return Created("Customer Added to Databse.", c_customer);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }

        [HttpGet("SearchCustomerByName")]
        public IActionResult SearchCustomer([FromQuery] string custName)
        {
            try
            {
                return Ok(_customerBL.SearchCustomerByName(custName));
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}