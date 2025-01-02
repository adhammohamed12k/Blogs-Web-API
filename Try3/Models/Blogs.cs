using System.ComponentModel.DataAnnotations;

namespace Try3.Models
{
    public class Blogs
    {
        [Key]
        public int BlogsId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int date_Time { get; set; }

        public User? User { get; set; }
    }
}
