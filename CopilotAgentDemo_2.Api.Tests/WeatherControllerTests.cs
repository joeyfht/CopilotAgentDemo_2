using CopilotAgentDemo_2.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CopilotAgentDemo_2.Api.Tests;

public class WeatherControllerTests
{
    private readonly WeatherController _controller = new();

    [Fact]
    public void Get_WhenCalled_ReturnsOkResult()
    {
        var result = _controller.Get();

        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void Get_WhenCalled_ReturnsSunny()
    {
        var result = _controller.Get();

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal("Sunny", okResult.Value);
    }
}
