using Microsoft.AspNetCore.Mvc;

namespace CopilotAgentDemo_2.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public ActionResult<CurrentWeatherResponse> Get() => Ok(new CurrentWeatherResponse("Sunny"));
}

public sealed record CurrentWeatherResponse(string Summary);
