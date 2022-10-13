using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrency.Pages
{
    public class CurrencyModel : PageModel
    {
        [BindProperty]
        public double Pounds { get; set; }
        
        [BindProperty]
        public double Rupees { get; set; }

        public double ConversionRate { get; set; } = 93;

        /// <summary>
        /// This method will initialise the web page
        /// </summary>
        public void OnGet()
        {
            Pounds = 100.00;
        }

        /// <summary>
        /// This method will be called when the user
        /// suubmits the page 
        /// </summary>
        public void OnPost()
        {
            Rupees = Pounds * ConversionRate;
        }
    }
}
