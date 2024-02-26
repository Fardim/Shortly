namespace Shortly.Client.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public List<Url> Url { get; set; }
        public User()
        {
            Url = new List<Url>();
        }
    }
}
