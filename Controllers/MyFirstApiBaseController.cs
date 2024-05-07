using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    [HttpGet("health")]
    public IActionResult Health()
    {
        return Ok("It's working...");

    }

    protected string GetCustomerKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
