namespace exercicio1;

delegate decimal CalculateDiscount(decimal price);

class Program
{
    static void Main(string[] args)
    {
        var productPrice = InputTypeDecimal("Informe o preço do produto: ");

        CalculateDiscount applyDiscountFn = DiscountCalculator.Calculate;

        var priceWithDiscount = applyDiscountFn(productPrice);

        Console.WriteLine($"O preço do produto com desconto é: {priceWithDiscount:F2}");
    }

    private static decimal InputTypeDecimal(string message)
    {
        Console.Write(message);
        if (decimal.TryParse(Console.ReadLine() ?? "0", out var value))
        {
            return value;
        }

        Console.WriteLine("Valor inválido, tente novamente.");
        return InputTypeDecimal(message);
    }
}