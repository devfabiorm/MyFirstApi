using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communications.Reponses;
using MyFirstApi.Communications.Requests;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : MyFirstApiBaseController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id, [FromQuery] string name, [FromHeader] string? token)
    {
        var response = new User
        {
            Id = 1,
            Age = 10,
            Name = "Tester"
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisterUserJson
        {
            Id = 1,
            Name = request.Name,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>
        {
            new User { Id = 1, Age = 10, Name = "Wanderson" },
            new User { Id = 2, Age = 11, Name = "Paulo" }
        };

        var key = GetCustomerKey();

        return Ok(key);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword()
    {
        return NoContent();
    }
}
