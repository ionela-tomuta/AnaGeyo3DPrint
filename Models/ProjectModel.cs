namespace AnaGeyo3DPrint.Models
{
    public class ProjectModel
    {
        public int Id { get; set; } // Cheia primară
        public string Name { get; set; } // Numele proiectului
        public string Description { get; set; } // Descriere
        public string FilePath { get; set; } // Calea fișierului încărcat
        public string Material { get; set; } // Materialul
        public string Color { get; set; } // Culoarea
        public decimal Price { get; set; } // Preț estimat

        public ICollection<OrderModel>? Orders { get; set; } // Comenzile asociate proiectului
    }
}
