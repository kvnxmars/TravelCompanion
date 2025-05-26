using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TravelCompanionAPI.Models;

namespace TravelCompanionAPI.Data
{
    public class TravelCompanionAPIContext :DbContext
    {
        public TravelCompanionAPIContext(DbContextOptions<TravelCompanionAPIContext> options) : base(options)
        { }

        public DbSet<TravelPlan> TravelPlans { get; set; } = default!;
        
    }
}
