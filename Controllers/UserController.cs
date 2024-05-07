using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get(int id)
    {
        var response = new Response
        {
            Id = 1,
            Age = 10,
            Name = "Tester"
        };

        return Ok(response);
    }
}
