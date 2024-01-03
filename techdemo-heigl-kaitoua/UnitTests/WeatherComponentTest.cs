using Xunit;
using static techdemo_heigl_kaitoua.Components.Pages.Weather;

public class WeatherComponentTest
{
    [Fact]
    public void TemperatureF_ReturnsCorrectValue()
    {
        // Arrange
        var weatherForecast = new WeatherForecast
        {
            TemperatureC = 0 // Celsius temperature
        };

        // Act
        int temperatureF = weatherForecast.TemperatureF;

        // Assert
        int expectedFahrenheit = 32; // Expected Fahrenheit conversion of 0 Celsius
        Assert.Equal(expectedFahrenheit, temperatureF);
    }
}
