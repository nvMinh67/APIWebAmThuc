using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class detailContact
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
