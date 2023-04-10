namespace webanthuc.Model
{
    public class DishInformation
    {
        public int ID { get; set; }
        public int maso { get; set; }
        public string Name { get; set; }
        public double price { get; set; }

        public int restaurantId { get; set; }

        public List<string> Image { get; set; }
    }
}
