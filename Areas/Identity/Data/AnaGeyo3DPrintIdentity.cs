using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnaGeyo3DPrint.Data;

public class AnaGeyo3DPrintContext : IdentityDbContext<IdentityUser>
{
    public AnaGeyo3DPrintContext(DbContextOptions<AnaGeyo3DPrintContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
