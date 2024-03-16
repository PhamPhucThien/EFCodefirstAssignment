using System.ComponentModel.DataAnnotations;

namespace EFCodefirstAssignment.Models
{
    public class OrderProduct
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public string Note { get; set; } = string.Empty;
        public float Discount { get; set; } = 0;
        public Order? Order { get; set; }
        public Guid? OrderId { get; set; }
    }
}
