using DevCars.API.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Controllers
{
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        //Post api/customers
        [HttpGet]
        public IActionResult Post([FromBody] AddCustomerInputModel model)
        {
            return Ok();
        }

        //Post api/customers/2/orders
        [HttpPost("{id}")]
        public IActionResult PostOrder(int id, [FromBody] AddOrderInputModel model)
        {
            return Ok();
        }

        //Get api/customers/1/orders/3
        [HttpGet("{id}/orders/{orderid}")]
        public IActionResult GetOrder(int id, int orderid)
        {
            return Ok();
        }
    }
}
