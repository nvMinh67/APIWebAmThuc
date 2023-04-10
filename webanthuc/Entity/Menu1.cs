using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    public class Menu1
    {

        [Key]
        public int Id { get; set; }
        public int? id_restaurant1 { get; set; }
        [ForeignKey("id_restaurant1")]
        public Restaurant1 Restaurant1 { get; set; }
        public int? id_dish1 { get; set; }
        [ForeignKey("id_dish1")]
        public Dish1 Dish1 { get; set; }

       
    }
}
