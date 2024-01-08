using FormulaOne.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormulaOne.Infrastructure.Data.Configurations;

public class AchievementConfiguration : IEntityTypeConfiguration<Achievement>
{
    public void Configure(EntityTypeBuilder<Achievement> builder)
    {
        builder.ToTable("achievements");

        builder
            .HasOne(ach => ach.Driver)
            .WithMany(d => d.Achievements)
            .HasForeignKey(ach => ach.DriverId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_Achievements_Driver");

        builder.Property(ach => ach.Id).HasColumnName("achievement_id");
        builder.Property(ach => ach.AddedDate).HasColumnName("added_date");
        builder.Property(ach => ach.UpdateDate).HasColumnName("update_date");
        builder.Property(ach => ach.Status).HasColumnName("status");
        builder.Property(ach => ach.RaceWins).HasColumnName("race_wins");
        builder.Property(ach => ach.PolePosition).HasColumnName("pole_position");
        builder.Property(ach => ach.FastestLop).HasColumnName("fastest_lop");
        builder.Property(ach => ach.WorldChampionship).HasColumnName("world_championship");
        builder.Property(ach => ach.DriverId).HasColumnName("driver_id");
    }
}
