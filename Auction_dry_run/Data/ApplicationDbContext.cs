using Auction_dry_run.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auction_dry_run.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public DbSet<listing> listings { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Comment> Comments { get; set; }



    }
}
