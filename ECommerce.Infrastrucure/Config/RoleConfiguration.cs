using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastrucure.Config;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
             new IdentityRole
             {
                 Id = "0ea0f3fb-1fad-4933-8f4f-fe63449ded16",
                 Name = "Admin",
                 NormalizedName = "ADMIN"
             },
             new IdentityRole
             {
                 Id = "4ee7d081-c558-4b63-887c-7c5c7a8482d0",
                 Name = "Customer",
                 NormalizedName = "CUSTOMER"
             }
        );

    }
}
