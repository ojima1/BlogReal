using Microsoft.AspNetCore.Identity;

namespace BlogReal.Models
{
    public class ApplicationUser:IdentityUser
    {
        public String? FirstName { get; set; }
        public string? LastName { get; set;}
        //relation
        public List<Post> Posts { get; set; }
    }
}
