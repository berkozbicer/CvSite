using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CvSite.Models;
using System.Text.Json;

namespace CvSite.Pages;

public class IndexModel : PageModel
{
    public List<Project> Projects { get; set; } = new ();
    public void OnGet()
    {
        var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/projects.json");
        var json = System.IO.File.ReadAllText(jsonPath);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        Projects = JsonSerializer.Deserialize<List<Project>>(json);
    }
}