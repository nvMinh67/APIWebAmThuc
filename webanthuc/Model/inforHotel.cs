using System.ComponentModel.DataAnnotations;

namespace webanthuc.Model
{
    public class inforHotel
    {
        public string id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mapdata { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<string> Image { get; set; }
    }
}
