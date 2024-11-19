using AnaGeyo3DPrint.Data;
using AnaGeyo3DPrint.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace AnaGeyo3DPrint.Gallery
{
    public class DetailsModel : PageModel
    {
        private readonly AnaGeyo3DPrintDbContext _context;  // Am schimbat aici din Context în DbContext

        public DetailsModel(AnaGeyo3DPrintDbContext context)  // Și aici
        {
            _context = context;
        }

        public ProjectModel Project { get; set; }

        public void OnGet(int id)
        {
            Project = _context.Projects.FirstOrDefault(p => p.Id == id);
        }
    }
}