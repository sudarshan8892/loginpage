using loginPage.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Data;

public class loginPageContext : IdentityDbContext<loginPageUser>
{
    public loginPageContext(DbContextOptions<loginPageContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplictionUserEntityCongigration());
    }

    private class ApplictionUserEntityCongigration : IEntityTypeConfiguration<loginPageUser>
    {
        public void Configure(EntityTypeBuilder<loginPageUser> builder)
        {
            builder
            .Property(b => b.fristName).HasMaxLength(150);
            builder
           .Property(b => b.LastName).HasMaxLength(150);
            builder
           .Property(b => b.PhoneNumber).HasMaxLength(10);
        }
    }
}
