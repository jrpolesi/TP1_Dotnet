namespace exercicio4;

class Program
{
    static void Main(string[] args)
    {
        var temperatureSensor = new TemperatureSensor();
        temperatureSensor.TemperatureExceeded += OnTemperatureExceeded;

        while (true)
        {
            var temperature = InputTypeDouble("Digite a temperatura atual: ");

            temperatureSensor.Read(temperature);

            var shouldContinue = InputTypeString("Deseja continuar? (S/n): ");
            if (shouldContinue.Equals("N", StringComparison.CurrentCultureIgnoreCase))
            {
                break;
            }
        }
    }

    private static void OnTemperatureExceeded(double temperature)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"A temperatura excedeu os limites seguros: {temperature}");
        Console.ResetColor();
    }

    private static double InputTypeDouble(string message)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine() ?? "0", out var value))
        {
            return value;
        }

        Console.WriteLine("Valor inválido, tente novamente.");
        return InputTypeDouble(message);
    }

    private static string InputTypeString(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "";
    }
}