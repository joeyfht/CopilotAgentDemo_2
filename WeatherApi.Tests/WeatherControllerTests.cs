using WeatherApi.Controllers;

namespace WeatherApi.Tests;

public class WeatherControllerTests
{
    [Fact]
    public void Get_ReturnsSunny()
    {
        // Arrange
        var controller = new WeatherController();

        // Act
        var result = controller.Get();

        // Assert
        Assert.Equal("Sunny", result);
    }
}
