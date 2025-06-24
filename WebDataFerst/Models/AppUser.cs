using Microsoft.AspNetCore.Identity;

namespace WebDataFerst.Models
{
    public class AppUser : IdentityUser
    {
        public string UserName { get; set; }
   
    }
}
