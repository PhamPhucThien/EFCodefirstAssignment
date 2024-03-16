using System.ComponentModel.DataAnnotations;

namespace EFCodefirstAssignment.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } = false;
        public List<Order>? Order { get; set; }
    }
}
