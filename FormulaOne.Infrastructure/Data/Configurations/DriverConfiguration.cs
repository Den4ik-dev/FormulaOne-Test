using FormulaOne.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormulaOne.Infrastructure.Data.Configurations;

public class DriverConfiguration : IEntityTypeConfiguration<Driver>
{
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        builder.ToTable("drivers");

        builder.Property(d => d.Id).HasColumnName("achievement_id");
        builder.Property(d => d.AddedDate).HasColumnName("added_date");
        builder.Property(d => d.UpdateDate).HasColumnName("update_date");
        builder.Property(d => d.Status).HasColumnName("status");
        builder.Property(d => d.FirstName).HasColumnName("first_name");
        builder.Property(d => d.LastName).HasColumnName("last_name");
        builder.Property(d => d.DriverNumber).HasColumnName("driver_number");
        builder.Property(d => d.DateOfBirth).HasColumnName("date_of_birth");
    }
}
