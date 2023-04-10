using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public int? id_restaurant { get; set; }
        [ForeignKey("id_restaurant")]
        public Restaurant Restaurant { get; set; }
        public int? id_dish { get;set; }
        [ForeignKey("id_dish")]
         public Dish Dish { get; set; }

        public double price { get; set; }
    }
}
