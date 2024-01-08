using AutoMapper;
using FormulaOne.Application.Common.Interfaces;
using FormulaOne.Domain;
using MediatR;

namespace FormulaOne.Application.Drivers.Commands.CreateDriver;

public class CreateDriverCommandHandler : IRequestHandler<CreateDriverCommand, Guid>
{
    private IApplicationDbContext _context;
    private IMapper _mapper;

    public CreateDriverCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateDriverCommand request, CancellationToken cancellationToken)
    {
        Driver newDriver = _mapper.Map<Driver>(request);

        await _context.Drivers.AddAsync(newDriver);

        await _context.SaveChangesAsync(cancellationToken);

        return newDriver.Id;
    }
}
