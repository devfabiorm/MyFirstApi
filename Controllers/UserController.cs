using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var response = new Response
        {
            Age = 10,
            Name = "Tester"
        };

        return Ok(response);
    }
}
