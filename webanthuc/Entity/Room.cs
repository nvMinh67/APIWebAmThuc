using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Room
    {
        public int Id { get; set; }
        public int id_TypeRoom { get; set; }
        [ForeignKey("id_TypeRoom")]
        public TypeRoom TypeRoom { get; set; }
    }
}
