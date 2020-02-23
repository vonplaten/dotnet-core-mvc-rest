using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CoreRest.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString(){
            return new string[] {"this", "is", "a", "string", "arr"};
        }
        
    }
}