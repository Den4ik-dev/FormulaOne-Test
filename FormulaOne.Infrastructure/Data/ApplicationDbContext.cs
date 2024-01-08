using FormulaOne.Application.Common.Interfaces;
using FormulaOne.Domain;
using FormulaOne.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FormulaOne.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Driver> Drivers => Set<Driver>();
    public DbSet<Achievement> Achievements => Set<Achievement>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AchievementConfiguration());
        modelBuilder.ApplyConfiguration(new DriverConfiguration());
    }
}
