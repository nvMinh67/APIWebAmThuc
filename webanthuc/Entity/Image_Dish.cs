using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Image_Dish
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int? IdDish { get; set; }
        [ForeignKey("IdDish")]
        public Dish Dish { get; set; }


    }
}
