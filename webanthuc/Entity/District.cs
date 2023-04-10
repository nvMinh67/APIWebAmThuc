using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int? id_City { get; set; }
        [ForeignKey("id_City")]
        public City ctiy { get; set; }
    }
}
