using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab3.Pages
{
    public class TestPageModel : PageModel
    {
        [Display(Name = "Ilo�� powt�rze�")]
        [BindProperty(Name = "ilosc_powtorzen")]
        public int TimesRepeat { get; set; }

        [Display(Name = "Imi�")]
        [BindProperty(Name = "imie")]
        public string Name { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(
            [Required][Display(Name = "Ilo�� powt�rze�")][Range(1, 5)] int timesRepeat,
            [Required][Display(Name = "Imi�")] string name)
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            TimesRepeat = timesRepeat;
            Name = name;

            return Page();
        }
    }
}
