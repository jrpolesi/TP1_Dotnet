namespace exercicio10.Data;

public static class ProductRepository
{
    private static readonly List<Product> Products =
    [
        new Product { Name = "Banana", Price = 1.20m },
        new Product { Name = "Maçã", Price = 2.50m },
        new Product { Name = "Laranja", Price = 1.80m }
    ];

    public static List<Product> GetAll() => Products;

    public static void Add(Product product)
    {
        Products.Add(product);
    }
}