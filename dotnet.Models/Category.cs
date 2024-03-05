using System.ComponentModel.DataAnnotations;

namespace dotnet.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
