using AutoMapper;
using FormulaOne.Application.Common.Interfaces;
using FormulaOne.Domain;
using MediatR;

namespace FormulaOne.Application.Drivers.Commands.UpdateDriver;

public class UpdateDriverCommandHandler : IRequestHandler<UpdateDriverCommand, bool>
{
    private IApplicationDbContext _context;
    private IMapper _mapper;

    public UpdateDriverCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<bool> Handle(UpdateDriverCommand request, CancellationToken cancellationToken)
    {
        if (
            await _context.Drivers.FindAsync(new object[] { request.DriverId }, cancellationToken)
            == null
        )
            return false;

        Driver updatedDriver = _mapper.Map<Driver>(request);

        _context.Drivers.Update(updatedDriver);
        await _context.SaveChangesAsync(cancellationToken);

        return true;
    }
}
