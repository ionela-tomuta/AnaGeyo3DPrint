using AnaGeyo3DPrint.Data;
using AnaGeyo3DPrint.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AnaGeyo3DPrint.Orders
{
    public class ListModel : PageModel
    {
        private readonly AnaGeyo3DPrintDbContext _context;

        public ListModel(AnaGeyo3DPrintDbContext context)
        {
            _context = context;
        }

        public IList<OrderModel> Orders { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders.ToListAsync();
        }
    }
}
