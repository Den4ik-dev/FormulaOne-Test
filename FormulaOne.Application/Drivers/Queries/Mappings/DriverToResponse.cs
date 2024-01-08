using AutoMapper;
using FormulaOne.Domain;

namespace FormulaOne.Application.Drivers.Queries.Mappings;

internal class DriverToResponse : Profile
{
    public DriverToResponse()
    {
        CreateMap<Driver, DriverBriefDto>()
            .ForMember(
                dest => dest.FullName,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")
            );
    }
}
