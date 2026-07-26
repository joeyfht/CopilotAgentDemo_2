using Microsoft.AspNetCore.Mvc;

namespace CopilotAgentDemo_2.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public string Get() => "Sunny";
}
