using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Countrys.Pages
{
    public class CountrysModel : PageModel
    {
        public List<string> CountriesList { get; set; } = new List<string>();

        public void OnGet()
        {
            CountriesList = new List<string>
            {
                "USA", "Ukraine", "United Kingdom", "Italy", "Germany", "Japan", "France", "Australia", "Finland"
            };
        }
    }
}