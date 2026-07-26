using Microsoft.AspNetCore.Mvc;
using WeatherApi.Controllers;

namespace WeatherApi.Tests;

public class WeatherControllerTests
{
    private readonly WeatherController _controller = new();

    [Fact]
    public void Get_ReturnsOkResult()
    {
        var result = _controller.Get();

        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void Get_ReturnsSunnyCondition()
    {
        var result = _controller.Get();

        var ok = Assert.IsType<OkObjectResult>(result);
        var value = ok.Value!;
        var conditionProperty = value.GetType().GetProperty("condition");
        Assert.NotNull(conditionProperty);
        Assert.Equal("Sunny", conditionProperty.GetValue(value));
    }
}
