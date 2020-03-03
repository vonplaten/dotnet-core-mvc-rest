using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CoreRest.Models;

namespace CoreRest.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // private readonly CustomerContext _context;

        // public CustomerController(CustomerContext context){
        //     _context = context;
        // }

        // [HttpGet]
        // public ActionResult<IEnumerable<Customer>> GetCustomerItems(){
        //     return this._context.CustomerItems;
        // }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(){
            return new string[] {"this", "is", "a", "string", "arr"};
        }

        public IActionResult Hello()
        {
            return View();
        }    
        
    }
}