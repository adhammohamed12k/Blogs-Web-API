using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Try3.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [EmailAddress]
        public string? UserEmail { get; set; }
        [Phone]
        public string? UserPhone { get; set; }

        public List<Blogs>? Blogs { get; set; }
        public List<Reaction>? Reactions { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
    }
}
