using Microsoft.AspNetCore.Identity;

namespace RestaurantManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
