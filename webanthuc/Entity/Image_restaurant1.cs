using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Image_restaurant1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? IdRestaurant1 { get; set; }
        [ForeignKey("IdRestaurant1")]
        public Restaurant1 Restaurant1 { get; set; }
    }
}
