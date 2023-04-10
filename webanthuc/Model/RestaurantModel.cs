using System.ComponentModel.DataAnnotations;

namespace webanthuc.Model
{
    public class RestaurantModel
    {
     
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Phone { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public string Mapdata { get; set; }
        public int capacity { get; set; }
        [Required]
        public string about { get; set; }
        public List<IFormFile> ImageUpload { get; set; }    
    }
}
