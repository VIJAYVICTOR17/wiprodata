using DotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCore.Pages
{
    public class EmployShowModel : PageModel
    {
        public List<Employ>? Employs { get; set; }
        public void OnGet()
        {
            Employs = new List<Employ>
            {
                new Employ{EmpId =1, Name ="Vijay", Salary = 25000},
                new Employ{EmpId =2, Name ="Deva", Salary = 36000},
                new Employ{EmpId =3, Name ="Sai", Salary = 38000}
            };
        }
    }
}
