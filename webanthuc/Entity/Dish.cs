using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    [Table("Dish")]
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        public virtual ICollection<Image_Dish> Image_Dishes { get; set; }
    }
}
