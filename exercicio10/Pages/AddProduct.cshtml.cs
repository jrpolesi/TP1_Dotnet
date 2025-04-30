using System.ComponentModel.DataAnnotations;
using exercicio10.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio10.Pages;

public class AddProductModel : PageModel
{
    [BindProperty] 
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Name { get; set; }

    [BindProperty] 
    [Required(ErrorMessage = "O preço é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que 0.")]
    public decimal? Price { get; set; }
    
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid || Price == null)
        {
            return Page();
        }

        ProductRepository.Add(new Product
        {
            Name = Name,
            Price = Price.Value
        });

        return RedirectToPage("/Index");
    }
}