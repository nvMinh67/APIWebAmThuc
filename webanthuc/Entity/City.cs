using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    public class City
    {
        [Key,Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
