using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    public class Image_Dish1
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int? IdDish1 { get; set; }
        [ForeignKey("IdDish1")]
        public Dish1 Dish1 { get; set; }
    }
}
