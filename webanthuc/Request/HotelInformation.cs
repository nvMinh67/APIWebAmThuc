using System.ComponentModel.DataAnnotations;

namespace webanthuc.Request
{
    public class HotelInformation
    {
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mapdata { get; set; }
        public string Phone { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }   

        public List<IFormFile> ImageUploads { get; set; }
    }
}
