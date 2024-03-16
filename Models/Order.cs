using System.ComponentModel.DataAnnotations;

namespace EFCodefirstAssignment.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public List<OrderProduct>? OrderProducts { get; set; }
    }
}
