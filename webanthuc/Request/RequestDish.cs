using System.ComponentModel.DataAnnotations;

namespace webanthuc.Request
{
    public class RequestDish
    {
        [Required]
        [MaxLength(255)]
        public string name { get; set; }
        public double price { get; set; }
        public string status { get; set; }

        public List<IFormFile> ImageUploads { get; set; }
    }
}
