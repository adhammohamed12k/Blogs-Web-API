using System.ComponentModel.DataAnnotations;

namespace Try3.DTO_s.ReactionDTO_s
{
    public class ReactionDTO
    {
        [Required]
        public string? ReactionType { get; set; }
    }
}
