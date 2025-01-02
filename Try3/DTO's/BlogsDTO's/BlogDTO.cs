using System.ComponentModel.DataAnnotations;

namespace Try3.DTO_s.BlogsDTO_s
{
    public class BlogDTO
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public int date_Time { get; set; }
    }
}
