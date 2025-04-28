namespace exercicio4;

public class TemperatureSensor()
{
    public event Action<double>? TemperatureExceeded;

    public void Read(double temperature)
    {
        Console.WriteLine("A temperatura atual é: " + temperature);

        if (temperature > 100)
        {
            TemperatureExceeded?.Invoke(temperature);
        }
    }
}