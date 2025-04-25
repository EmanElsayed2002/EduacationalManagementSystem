using Microsoft.AspNetCore.Identity;

namespace DATA.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public ICollection<UserRefreshToken> RefreshTokens { get; set; }
    }
}
