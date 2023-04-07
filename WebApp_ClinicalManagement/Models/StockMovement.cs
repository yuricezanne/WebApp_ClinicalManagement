using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ClinicalManagement.Models
{
    public class StockMovement
    {
        public int ID { get; set; } // primary key
        public bool Type { get; set; } // True - Inlet, False - Outlet
        public int Amount { get; set; } // Movement Quantity
        public DateTime MovementDate { get; set; } // Date of Movement
        public int ItemID { get; set; } // Foreign Key
        public Item Item { get; set; } // this variable belongs to item class
    }
}
