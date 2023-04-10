using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    public class DetailContact1
    {
        [Key]
        public int Id { get; set; }
        public int? id_Contact { get; set; }
        [ForeignKey("id_Contact")]
        public Contact contact { get; set; }
        public int? id_Restaurant1 { get; set; }
        [ForeignKey("id_Restaurant1")]
        public Restaurant1 restaurant1 { get; set; }
    }
}
