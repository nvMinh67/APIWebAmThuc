using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    public class Restaurant
    {
        [Key]
        [Required]
        public int? Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Phone { get; set; }
        [Required,MaxLength(100)]
        public string Email { get; set; }
        [Required,MaxLength (100)]
        public string Mapdata { get; set; }

        public int capacity { get; set; }
        [Required]
        public string about { get; set; }

        public virtual ICollection<Image_Restaurant> Image_Restaurant { get; set; }

    }
}
