using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_EF_Customer.Model
{
    public class Customer
    {
        public int Id { get; set; } // PK

        [Required(ErrorMessage = "Please Enter Name")]
        [DisplayName("Full Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Contact #")]
        [Column(TypeName = "nvarchar(30)")]
        public string Contact { get; set; } 
        public string? Address { get; set; } 
    }
}
