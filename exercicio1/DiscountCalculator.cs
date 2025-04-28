namespace exercicio1;

public class DiscountCalculator
{
    private const decimal Discount = 10m / 100m;

    public static decimal Calculate(decimal price)
    {
        var discountValue = price * Discount;

        return price - discountValue;
    }
}