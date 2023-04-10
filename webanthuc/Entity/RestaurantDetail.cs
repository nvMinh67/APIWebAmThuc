using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class RestaurantDetail
    {
        public int Id { get; set; }
        public int id_restaurant { get; set; }
        [ForeignKey("id_restaurant")]
        public Restaurant1 Restaurant1 { get; set; }
        public string id_user { get; set; }
        [ForeignKey("id_user")]
        public ApplicationUser user { get; set; }


        
    }
}
