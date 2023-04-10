using System.ComponentModel.DataAnnotations;
using webanthuc.Entity;
using webanthuc.Migrations;

namespace webanthuc.Model
{
    public class inforOneHotel
    {
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mapdata { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,Phone]
        public string Phone { get; set; }   

        public List<string> Image { get; set; } 

        public List<InforRoom> Roomdetails { get; set; }
    }
}
