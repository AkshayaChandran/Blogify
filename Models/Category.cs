using System.ComponentModel.DataAnnotations;

namespace Blogify.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Category Name is required")]
        [MaxLength(100,ErrorMessage ="The Category Name cannot exceed 100 characters")]
        public required string Name { get; set; }

        public  string? Description { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}
