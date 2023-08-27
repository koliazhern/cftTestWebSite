namespace CftTestWebSite.Models
{
    public class Claim
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Application { get; set; }

        public DateTime? DateEnd { get; set; }

        public string Description { get; set;}

        public string Email { get; set; }
    }
}
