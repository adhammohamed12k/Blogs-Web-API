using System.ComponentModel.DataAnnotations;
using Try3.DTO_s.BlogsDTO_s;
using Try3.DTO_s.ReactionDTO_s;
using Try3.DTO_s.RoleDTO_s;
using Try3.Models;

namespace Try3.DTO_s.UserDTO_s
{
    public class AddAllDTO
    {
        [EmailAddress]
        public string? UserEmail { get; set; }
        [Phone]
        public string? UserPhone { get; set; }

        public ICollection<BlogDTO> Blogs { get; set; } = new List<BlogDTO>();

        public ICollection<ReactionDTO> Reactions { get; set; }= new List<ReactionDTO>();
        public RoleDTO Roledto { get; set; } = new RoleDTO();
    }
}
