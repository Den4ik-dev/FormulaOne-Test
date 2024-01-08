using FormulaOne.Domain;

namespace FormulaOne.Application.Drivers.Queries;

public class DriverBriefDto
{
    public Guid DriverId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public int DriverNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
}
