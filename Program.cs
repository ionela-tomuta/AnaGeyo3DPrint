using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AnaGeyo3DPrint.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurarea conexiunii la baza de date
var connectionString = builder.Configuration.GetConnectionString("AnaGeyo3DPrintContextConnection")
    ?? throw new InvalidOperationException("Connection string 'AnaGeyo3DPrintContextConnection' not found.");
builder.Services.AddDbContext<AnaGeyo3DPrintDbContext>(options =>
    options.UseSqlServer(connectionString));

// Configurarea Identity pentru autentificare
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AnaGeyo3DPrintDbContext>();

// Adãugarea Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Configurarea pipeline-ului HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.Run();
