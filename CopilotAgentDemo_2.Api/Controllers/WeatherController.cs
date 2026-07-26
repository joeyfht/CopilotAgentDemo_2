using Microsoft.AspNetCore.Mvc;

namespace CopilotAgentDemo_2.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Sunny");
}
