using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BlueWolfRazor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [DisplayName("Category Name")]
        public string Name { get; set; } = default!;
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int Displayorder { get; set; }
    }
}
