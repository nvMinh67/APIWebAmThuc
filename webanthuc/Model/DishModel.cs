using System.ComponentModel.DataAnnotations;

namespace webanthuc.Model
{
    public class DishModel
    {
        [Required]
        public int maso { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public List<IFormFile> ImageUploads { get; set; }
    }
}
