using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio8.Pages;

public class MoreModel : PageModel
{
    private readonly ILogger<MoreModel> _logger;

    public MoreModel(ILogger<MoreModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}