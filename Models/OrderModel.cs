using Microsoft.AspNetCore.Identity;

namespace AnaGeyo3DPrint.Models
{
    public class OrderModel
    {
        public int Id { get; set; } // Cheia primară
        public int ProjectId { get; set; } // Legătura cu un proiect
        public string UserId { get; set; } // ID-ul utilizatorului
        public DateTime OrderDate { get; set; } // Data comenzii
        public decimal EstimatedCost { get; set; } // Cost estimat
        public string Status { get; set; } // Statusul comenzii (ex. "În procesare")

        public ProjectModel? Project { get; set; } // Proiect asociat
        public IdentityUser? User { get; set; } // Utilizator asociat
    }
}
