using AnaGeyo3DPrint.Data;
using AnaGeyo3DPrint.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace AnaGeyo3DPrint.Pages.Gallery
{
    public class GalleryModel : PageModel
    {
        private readonly AnaGeyo3DPrintDbContext _dbContext;

        public List<ProjectModel> Projects { get; set; }

        public GalleryModel(AnaGeyo3DPrintDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Projects = _dbContext.Projects.ToList();
        }
    }
}
