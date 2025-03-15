using System.ComponentModel.DataAnnotations;

namespace InventoryManagementAPI.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        [MaxLength(100)]
        public string SupplierName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}