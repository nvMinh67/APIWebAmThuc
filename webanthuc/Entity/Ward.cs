using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Ward
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int? id_District { get; set; }
        [ForeignKey("id_District")]
        public District dishtrict { get; set; }
    }
}
