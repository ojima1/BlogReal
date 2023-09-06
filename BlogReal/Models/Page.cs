namespace BlogReal.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public String? ShortDescription { get; set; }
        public String? Description { get; set;}
        public String Slug { get; set; }
    }
}
