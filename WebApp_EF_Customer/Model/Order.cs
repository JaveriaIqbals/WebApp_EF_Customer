using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_EF_Customer.Model
{
    public class Order
    {
        public int Id { get; set; } // PK
        public int CustId {get; set;} // FK

        [Required(ErrorMessage = "Please Enter Tracking Number!")]
        [Column(TypeName = "nvarchar(15)")]
        public string TrackingNum { get; set; }

        [Required(ErrorMessage = "Please Enter Order Total!")]
        [Column(TypeName = "nvarchar(100)")]
        public double OrderTotal { get; set; }  
    }
}
