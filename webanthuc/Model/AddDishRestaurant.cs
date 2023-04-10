namespace webanthuc.Model
{
    public class AddDishRestaurant
    {
        public string dishName { get; set; }
        
        public string dishPrice { get; set; }

        public List<IFormFile> imageUpload { get; set; }


    }
}
