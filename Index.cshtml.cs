using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoubleNotchedCylinderApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double Radius { get; set; }

        [BindProperty]
        public double Height { get; set; }

        [BindProperty]
        public double Depth { get; set; }

        [BindProperty]
        public double Width { get; set; }

        public double Volume { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            double cylinderVolume = Math.PI * Radius * Radius * Height;
            double notchVolume = 2 * (Width * Depth * Height);

            Volume = cylinderVolume - notchVolume;
        }
    }
}