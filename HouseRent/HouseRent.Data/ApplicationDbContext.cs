using HouseRent.Data.DataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRent.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.
                Entity<House>()
                .HasOne(h => h.Category)
                .WithMany(c => c.Houses)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<House>()
               .HasOne(h => h.Agent)
               .WithMany()
               .HasForeignKey(h => h.AgentId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
