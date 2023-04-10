using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Image_Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? IdRestaurant { get; set; }
        [ForeignKey("IdRestaurant")]
        public Restaurant Restaurant { get; set; }
    }
}
