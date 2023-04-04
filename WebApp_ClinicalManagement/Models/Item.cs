using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ClinicalManagement.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";

        [Column(TypeName = "money")] // column type annotation
        public decimal? Price { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Discontinued { get; set; }
        
    }
}
