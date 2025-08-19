using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RajorExamples.Models;
using System.ComponentModel.DataAnnotations;


namespace RajorExamples.Pages.Employs
{
    public class CreateModel : PageModel
    {
        private readonly EFcoreDbContext _context;
        public CreateModel(EFcoreDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employ Employ { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Employees.Add(Employ);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
