using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ClinicalManagement.Models
{
    public class StockMovement
    {
        public int ID { get; set; } // primary key
        public bool Type { get; set; }
        public int Amount { get; set; }
        public DateTime MovementDate { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; } // this variable belongs to item class, foreign key
    }
}
