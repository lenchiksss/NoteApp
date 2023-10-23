using System.ComponentModel.DataAnnotations;

namespace NoteApp.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Text { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public string? Tags { get; set; }
    }
}
