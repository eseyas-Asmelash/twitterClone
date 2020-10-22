using System.ComponentModel.DataAnnotations;

namespace MyTwitter.Models
{
    public class PostMessage
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        [StringLength(44, ErrorMessage = "Text must be less than 44 caracter")]
        public string Message { get; set; }

    }
}
