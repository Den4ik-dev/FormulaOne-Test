using MediatR;

namespace FormulaOne.Application.Drivers.Queries.GetAllDrivers;

public class GetAllDriversQuery : IRequest<IEnumerable<DriverBriefDto>> { }
