using System.ComponentModel.DataAnnotations;

namespace webanthuc.Response
{
    public class RestaurantInformation
    {
        public string name { get; set; }

        public List<String> image { get; set; }

        public List<String> Dish { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Mapdata { get; set; }

        public int capacity { get; set; }

        public string about
        {
            get; set;

        }
        public string address { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string ward { get; set; }

    }
}
