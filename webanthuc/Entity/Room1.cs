using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Room1
    {
        public int Id { get; set; }
    
        public int Id_TypeRoom { get; set; }
        [ForeignKey("Id_TypeRoom")]
        public TypeRoom TypeRoom { get; set; }
    }
}
