using System;
using Xunit;
using Xunit.Abstractions;

using TestApi;

namespace Tests
{
    public class UnitTest1
    {
        ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output){
            _output = output;
        }

        [Theory]
        [InlineData(40, "Sweltering")]
        [InlineData(56, "Sweltering")]
        [InlineData(30, "Hot")]
        [InlineData(33, "Hot")]
        [InlineData(39, "Hot")]
        [InlineData(29, "Warm")]
        [InlineData(20, "Warm")]
        [InlineData(19, "Mild")]
        [InlineData(10, "Mild")]
        [InlineData(9, "Chilly")]
        [InlineData(0, "Chilly")]
        [InlineData(-1, "Cold")]
        [InlineData(-10, "Cold")]
        [InlineData(-11, "Freezing")]
        [InlineData(-20, "Freezing")]
        public void TempRangeTest(int temp, string summary)
        {
            WeatherForecast weatherForecast = new WeatherForecast(0, temp) { };
            _output.WriteLine(weatherForecast.TemperatureC.ToString());
            _output.WriteLine(weatherForecast.Summary);
            Assert.Equal(summary, weatherForecast.Summary);
        }

        [Fact(Skip = "For Demo")]
        public void FailTest()
        {
            WeatherForecast weatherForecast = new WeatherForecast(0, 40) { };
            _output.WriteLine(weatherForecast.TemperatureC.ToString());
            _output.WriteLine(weatherForecast.Summary);
            Assert.Equal("Freezing", weatherForecast.Summary);
        }
    }
}
