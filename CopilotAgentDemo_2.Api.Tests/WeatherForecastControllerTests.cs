using Microsoft.AspNetCore.Mvc;
using CopilotAgentDemo_2.Api.Controllers;

namespace CopilotAgentDemo_2.Api.Tests;

public class WeatherForecastControllerTests
{
    [Fact]
    public void Get_Called_ReturnsSunny()
    {
        var controller = new WeatherForecastController();

        var result = controller.Get();
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var payload = Assert.IsType<CurrentWeatherResponse>(okResult.Value);

        Assert.Equal("Sunny", payload.Summary);
    }
}