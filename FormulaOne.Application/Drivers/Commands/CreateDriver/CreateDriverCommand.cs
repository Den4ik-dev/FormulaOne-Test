using MediatR;

namespace FormulaOne.Application.Drivers.Commands.CreateDriver;

public class CreateDriverCommand : IRequest<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LasName { get; set; } = string.Empty;
    public int DriverNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
}
