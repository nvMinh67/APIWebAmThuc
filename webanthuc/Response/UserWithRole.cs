namespace webanthuc.Response
{
    public class UserWithRole
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> Roles { get; set; } 
    }
}
