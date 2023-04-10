using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class ImageDetailRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Id_Room_Detail { get; set; }
        [ForeignKey("Id_Room_Detail")]
        public RoomDetail RoomDetail { get; set; }
    }
}
