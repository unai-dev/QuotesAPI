using System.ComponentModel.DataAnnotations;

namespace QuotesAPI.DTOs
{
    public class CreateQuoteDTO
    {
        [Required]
        public required string Text { get; set; }

        [MaxLength(50)]
        public string Author { get; set; } = "Anónimo";

        [MaxLength(50)]
        public string Category { get; set; } = "General";
    }
}
