using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    [Table("Dish1")]
    public class Dish1
    {
            [Key]
            public int Id { get; set; }
            [Required]
            [MaxLength(100)]
            public string Name { get; set; }
            public double price { get; set; }
            public virtual ICollection<Image_Dish1> Image_Dishes1 { get; set; }
        
    }
}
