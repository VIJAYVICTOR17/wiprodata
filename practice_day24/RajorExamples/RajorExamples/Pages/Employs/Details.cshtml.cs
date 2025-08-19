using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RajorExamples.Models;
using Microsoft.EntityFrameworkCore;

namespace RajorExamples.Pages.Employs
{
    public class DetailsModel : PageModel
    {
        private readonly EFcoreDbContext _dbContext;

        public DetailsModel(EFcoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Employ Employ { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _dbContext.Employees.Where(x => x.Empno == id).FirstOrDefaultAsync();

            //var employ = await _dbContext.Employees.FirstOrDefaultAsync(m => m.Empno == id);
            if (employ == null)
            {
                return NotFound();
            }
            else
            {
                Employ = employ;
            }
            return Page();
        }

    }
}
