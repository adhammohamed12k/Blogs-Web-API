using System.ComponentModel.DataAnnotations;

namespace Try3.Models
{
    public class Reaction
    {
        [Key]
       public int ReactionId { get; set; }
        [Required]
        public string? ReactionType { get; set; }
        public List<User>? users { get; set; }
    }
}
