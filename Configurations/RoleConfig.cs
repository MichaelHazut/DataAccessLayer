using DataAccessLayer.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "a1db2e6e-6d4f-4b36-bf6f-9e3fbd4b01e8",
                    Name = "None",
                    NormalizedName = "NONE",
                },
                new IdentityRole
                {
                    Id = "f98e0a2d-67a0-4391-bdbb-7a5c61505c3f",
                    Name = "Basic",
                    NormalizedName = "BASIC"
                },
                new IdentityRole
                {
                    Id = "bc38276b-2533-4d38-8e66-9216b7e9db3c",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
                );
        }
    }
}
