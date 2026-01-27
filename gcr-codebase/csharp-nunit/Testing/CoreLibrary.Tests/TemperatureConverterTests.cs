using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    [Test]
    public void Celsius_To_Fahrenheit_Test()
    {
        TemperatureConverter t = new TemperatureConverter();
        Assert.AreEqual(32, t.CelsiusToFahrenheit(0));
    }

    [Test]
    public void Fahrenheit_To_Celsius_Test()
    {
        TemperatureConverter t = new TemperatureConverter();
        Assert.AreEqual(0, t.FahrenheitToCelsius(32));
    }
}
