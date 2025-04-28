namespace exercicio3;

class Program
{
    static void Main(string[] args)
    {
        var rectangleBase = InputTypeDouble("Digite a base do retângulo: (em metros) ");
        var rectangleHeight = InputTypeDouble("Digite a altura do retângulo: (em metros) ");

        Func<double, double, double> calculateArea = CalculateRectangleArea;

        var area = calculateArea(rectangleBase, rectangleHeight);

        Console.WriteLine($"A área do retângulo é: {area}");
    }

    private static double CalculateRectangleArea(double baseValue, double heightValue)
    {
        return baseValue * heightValue;
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
}