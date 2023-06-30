using DataAccessLayer.Enums;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            builder.HasData(
                new User
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@email.com",
                    NormalizedEmail = "ADMIN@EMAIL.COM",
                    PasswordHash = hasher.HashPassword(null!, "123!Qaz123"),
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    AuthenticationLevel = AuthenticationLevel.Admin
                },

                new User
                {
                    Id = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    UserName = "TESTUSER@GMAIL.COM",
                    NormalizedUserName = "TESTUSER@GMAIL.COM",
                    Email = "testuser@gmail.com",
                    NormalizedEmail = "TESTUSER@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null!, "!Usertest"),
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    AuthenticationLevel = AuthenticationLevel.Basic
                }
            );
        }
    }
}
