using System.ComponentModel.DataAnnotations;

namespace Try3.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string? Rolee { get; set; }
        public User? User { get; set; }
    }
}
