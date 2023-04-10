using System.ComponentModel.DataAnnotations;

namespace webanthuc.Request
{
    public class inforRoom
    {
        [Required]
        public int RoomID { get; set; }
        [Required]
        public int HotelId { get; set; }
        public double Price { get; set; }

        public int Size { get; set; }
        public string View { get; set; }

        public bool IsActive { get; set; }

        public int capacity { get; set; }

        public List<IFormFile> Image { get; set; }



    }
}
