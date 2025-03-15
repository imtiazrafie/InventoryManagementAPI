using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementAPI.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseID { get; set; }

        public string ProductName { get; set; }

        public decimal PurchasePrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }
    }
}