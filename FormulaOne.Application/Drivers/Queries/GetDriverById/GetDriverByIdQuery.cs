using MediatR;

namespace FormulaOne.Application.Drivers.Queries.GetDriverById;

public class GetDriverByIdQuery : IRequest<DriverBriefDto?>
{
    public Guid DriverId { get; }
}
