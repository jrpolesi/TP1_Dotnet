namespace exercicio4;

public class TemperatureSensor(Action<double> onTemperatureExceeded)
{
    public event Action<double> TemperatureExceeded = onTemperatureExceeded;

    public void Read(double temperature)
    {
        Console.WriteLine("A temperatura atual é: " + temperature);

        if (temperature > 100)
        {
            TemperatureExceeded?.Invoke(temperature);
        }
    }
}