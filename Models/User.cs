#nullable disable

using DataAccessLayer.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public AuthenticationLevel AuthenticationLevel { get; set; }

        public User() { }
        public User(UserRegister newUser)
        {
            Name = newUser.Name;
            Email = newUser.Email;
            UserName = newUser.Email.ToUpperInvariant();
            NormalizedEmail = newUser.Email.ToUpperInvariant();
            AuthenticationLevel = AuthenticationLevel.Basic;
        }
    }
}
