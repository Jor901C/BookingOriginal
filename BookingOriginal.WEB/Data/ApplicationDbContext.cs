using BookingOriginal.WEB.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookingOriginal.WEB.Data
{
    public class ApplicationDbContext : IdentityDbContext<AllIDentity>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AllIDentity> Identities { get; set; }
    }
}
