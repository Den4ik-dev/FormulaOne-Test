using FormulaOne.Domain;
using Microsoft.EntityFrameworkCore;

namespace FormulaOne.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Driver> Drivers { get; }
    public DbSet<Achievement> Achievements { get; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
