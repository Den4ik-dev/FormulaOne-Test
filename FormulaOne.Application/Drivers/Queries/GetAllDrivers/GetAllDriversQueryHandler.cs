using AutoMapper;
using FormulaOne.Application.Common.Interfaces;
using MediatR;

namespace FormulaOne.Application.Drivers.Queries.GetAllDrivers;

public class GetAllDriversQueryHandler
    : IRequestHandler<GetAllDriversQuery, IEnumerable<DriverBriefDto>>
{
    private IApplicationDbContext _context;
    private IMapper _mapper;

    public GetAllDriversQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<DriverBriefDto>> Handle(
        GetAllDriversQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<DriverBriefDto> drivers = _mapper.Map<IEnumerable<DriverBriefDto>>(
            _context.Drivers
        );

        return drivers;
    }
}
