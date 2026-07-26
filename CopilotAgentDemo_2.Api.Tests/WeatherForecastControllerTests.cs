using CopilotAgentDemo_2.Api.Controllers;

namespace CopilotAgentDemo_2.Api.Tests;

public class WeatherForecastControllerTests
{
    [Fact]
    public void Get_Called_ReturnsSunny()
    {
        var controller = new WeatherForecastController();

        var result = controller.Get();

        Assert.Equal("Sunny", result);
    }
}