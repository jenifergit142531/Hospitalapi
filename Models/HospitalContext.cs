using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Models
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hospital> Hospital { get; set; }
    }
}
