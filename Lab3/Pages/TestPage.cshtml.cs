using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab3.Pages
{
    public class TestPageModel : PageModel
    {
        [Display(Name = "Iloœæ powtórzeñ")]
        [BindProperty(Name = "ilosc_powtorzen")]
        public int TimesRepeat { get; set; }

        [Display(Name = "Imiê")]
        [BindProperty(Name = "imie")]
        public string Name { get; set; }

        public IActionResult OnGetAsync()
        {
            return Page();
        }

        public IActionResult OnPost(
            [Required][Display(Name = "Iloœæ powtórzeñ")][Range(1, 5)] int timesRepeat,
            [Required][Display(Name = "Imiê")] string name)
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
