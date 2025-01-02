using System.ComponentModel.DataAnnotations;
using Try3.DTO_s.UserDTO_s;

namespace Try3.DTO_s.ReactionDTO_s
{
    public class ReactionAddAll
    {
        [Required]
        public string? ReactionType { get; set; }

        public ICollection<UserDTO> userDTOs { get; set; } = new List<UserDTO>();   
    }
}
