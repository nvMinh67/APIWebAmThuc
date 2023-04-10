using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    public class TypeRoom
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
