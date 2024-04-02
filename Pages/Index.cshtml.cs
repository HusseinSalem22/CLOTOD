using CLOTODO.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLOTODO.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<todoItem> TodoItems { get; set; } = [];

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        TodoItems = new List<todoItem>
        {
            new todoItem { Id = Guid.NewGuid(), Description = "Learn C#", IsComplete = false },
            new todoItem { Id = Guid.NewGuid(), Description = "Learn Razor Pages", IsComplete = false },
            new todoItem { Id = Guid.NewGuid(), Description = "Learn Blazor", IsComplete = false }
        };

    }
}
