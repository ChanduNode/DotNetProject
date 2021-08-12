using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // We define the routing that our controller going to use
  
    public class TodoController
    {
        [Route("TestRun")] // define the routing for this action
        [HttpGet]
        public ActionResult TestRun()
        {
            return Ok("success");
        }
    }
}