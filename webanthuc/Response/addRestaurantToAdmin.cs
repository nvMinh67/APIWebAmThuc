using System.ComponentModel.DataAnnotations;

namespace webanthuc.Response
{
    public class addRestaurantToAdmin
    {
        [Required]
        public string id_user { get; set; }
        [Required]
        public int id_restaurant { get; set; }
    }
}
