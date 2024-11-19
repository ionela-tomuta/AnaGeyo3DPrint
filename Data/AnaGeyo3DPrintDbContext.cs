namespace AnaGeyo3DPrint.Data
{
    using AnaGeyo3DPrint.Models;
    using Microsoft.EntityFrameworkCore;

    public class AnaGeyo3DPrintDbContext : DbContext
    {
        public AnaGeyo3DPrintDbContext(DbContextOptions<AnaGeyo3DPrintDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
    }
}
