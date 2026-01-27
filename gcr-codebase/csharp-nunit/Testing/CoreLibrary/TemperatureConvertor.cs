public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    public double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}
