using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }    

        public int id_Ward { get; set; }
        [ForeignKey("id_Ward")]
        public Ward Ward { get; set; }

    }
}
