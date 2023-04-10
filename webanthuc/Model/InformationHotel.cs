using System.ComponentModel.DataAnnotations;
using webanthuc.Entity;

namespace webanthuc.Model
{
    public class InformationHotel
    {
        public string id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mapdata { get; set; }

        public List<string> Image { get; set; }
    }
}
