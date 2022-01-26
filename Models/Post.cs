using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Post
    {
        // Entity Model Tanımları
        // Kolonu Primary Key olarak ayarlar.
        [Key]
        [Required]
        // Kolonu Auto Increment olarak ayarlar.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [Required]
        [MaxLength(30)]
        public string CreatedBy { get; set; }
    }
}
