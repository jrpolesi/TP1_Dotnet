using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio8.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<Product> Products = [];

    public void OnGet()
    {
        Products =
        [
            new Product { Name = "Banana", Price = 1.20m },
            new Product { Name = "Maçã", Price = 2.50m },
            new Product { Name = "Laranja", Price = 1.80m }
        ];
    }

    public class Product
    {
        public string Name = "";
        public decimal Price;
    }
}