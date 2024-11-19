using AnaGeyo3DPrint.Data;
using AnaGeyo3DPrint.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace AnaGeyo3DPrint.Pages.Gallery
{
    public class UploadModel : PageModel
    {
        private readonly AnaGeyo3DPrintDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;

        public UploadModel(AnaGeyo3DPrintDbContext dbContext, IWebHostEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        [BindProperty]
        public ProjectModel Project { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var file = Request.Form.Files.FirstOrDefault();
            if (file != null)
            {
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                Project.FilePath = "/uploads/" + fileName;
            }

            _dbContext.Projects.Add(Project);
            _dbContext.SaveChanges();

            return RedirectToPage("/Gallery/Index");
        }
    }
}
