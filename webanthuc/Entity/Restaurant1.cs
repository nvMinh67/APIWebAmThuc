using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    public class Restaurant1
    {
        [Key]
        [Required]
        public int? Id { get; set; }
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

    }
}
