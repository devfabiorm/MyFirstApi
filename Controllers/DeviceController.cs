using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = GetCustomerKey();

        return Ok(key);
    }
}
