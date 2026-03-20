using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello API");
    }
}