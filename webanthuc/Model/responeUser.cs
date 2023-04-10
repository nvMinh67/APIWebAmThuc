using webanthuc.Entity;

namespace webanthuc.Model
{
    public class responeUser
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Dish1> dish { get; set; }
    }
}
