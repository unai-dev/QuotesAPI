using System.ComponentModel.DataAnnotations;

namespace QuotesAPI.Models
{
    public class Quote
    {
        public int Id { get; set; }

        [Required]
        public required string Text { get; set; }

        [MaxLength(50)]
        public string Author { get; set; } = "Anónimo";

        [MaxLength(50)]
        public string Category { get; set; } = "General";
        public DateTime CreatedAt { get; set; } = new DateTime(2026, 04, 15);
    }
}
