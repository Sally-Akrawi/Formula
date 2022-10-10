using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages
{
    public class FormulaModel : PageModel
    {
        [BindProperty]
        public double Principal { get; set; }
        [BindProperty]
        public double InterestRate { get; set; }
        [BindProperty]
        public double Time { get; set; }
        [BindProperty]
        public double NumberOfPeriods { get; set; }
        public double A { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
           
            double C;
            double E;
            C = (1 + (InterestRate / Time));
            E = Time * NumberOfPeriods;
            A = Principal * Math.Pow(C, E);
           
        }
    }
}
