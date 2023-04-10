using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class Image_Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        public int id_Hotel { get; set; }
        [ForeignKey("id_Hotel")]
        public Hotel Hotel { get; set; }
    }
}
