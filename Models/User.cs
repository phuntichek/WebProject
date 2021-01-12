using Microsoft.AspNetCore.Identity;

namespace WebProject.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}