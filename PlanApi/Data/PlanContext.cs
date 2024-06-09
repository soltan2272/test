using Microsoft.EntityFrameworkCore;
using PlanApi.Models;

namespace PlanApi.Data
{
    public class PlanContext : DbContext
    {
        public PlanContext(DbContextOptions<PlanContext> options) : base(options) { }

        public DbSet<Plan> Plans { get; set; }
    }
}
