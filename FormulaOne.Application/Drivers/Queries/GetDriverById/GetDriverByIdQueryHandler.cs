using AutoMapper;
using FormulaOne.Application.Common.Interfaces;
using FormulaOne.Domain;
using MediatR;

namespace FormulaOne.Application.Drivers.Queries.GetDriverById;

internal class GetDriverByIdQueryHandler : IRequestHandler<GetDriverByIdQuery, DriverBriefDto?>
{
    private IApplicationDbContext _context;
    private IMapper _mapper;

    public GetDriverByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<DriverBriefDto?> Handle(
        GetDriverByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        Driver? driver = await _context.Drivers.FindAsync(
            new[] { request.DriverId },
            cancellationToken
        );

        if (driver == null)
            return null;

        return _mapper.Map<DriverBriefDto>(driver);
    }
}
