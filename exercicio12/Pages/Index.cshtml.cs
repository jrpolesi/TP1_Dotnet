using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using exercicio12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio12.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    [Required(ErrorMessage = "O campo 'Título' é obrigatório.")]
    public string Title { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "O campo 'Data' é obrigatório.")]
    [DataType(DataType.DateTime)]
    public DateTime Date { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "O campo 'Local' é obrigatório.")]
    public string Location { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Date = DateTime.Now;
    }

    public Action<Event> OnEventCreated => eventData =>
    {
        _logger.LogInformation("Novo evento - Título: {Title}, Data: {Date}, Local: {Location}", eventData.Title,
            eventData.Date, eventData.Location);
    };

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var eventData = new Event(Title, Date, Location);

        OnEventCreated?.Invoke(eventData);

        return RedirectToPage("/Index");
    }
}