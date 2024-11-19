using AnaGeyo3DPrint.Data;
using AnaGeyo3DPrint.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AnaGeyo3DPrint.Gallery
{
    public class IndexModel : PageModel
    {
        private readonly AnaGeyo3DPrintDbContext _context;

        public IndexModel(AnaGeyo3DPrintDbContext context)
        {
            _context = context;
        }

        public IList<ProjectModel> Projects { get; set; } = new List<ProjectModel>();

        public async Task OnGetAsync()
        {
            Projects = await _context.Projects.ToListAsync();
        }
    }
}
