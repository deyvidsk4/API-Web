using Microsoft.EntityFrameworkCore;

namespace WebAPIServ.Models
{
    public class PollDbContext : DbContext
    {
        public PollDbContext(DbContextOptions<PollDbContext> options)
        : base(options)
        { }
        
          public DbSet<Poll> Polls {get; set; }  
        }
    }
