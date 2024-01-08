using AutoMapper;
using FormulaOne.Application.Drivers.Commands.CreateDriver;
using FormulaOne.Application.Drivers.Commands.UpdateDriver;
using FormulaOne.Domain;

namespace FormulaOne.Application.Drivers.Commands.Mappings;

internal class DriverToRequest : Profile
{
    public DriverToRequest()
    {
        CreateMap<CreateDriverCommand, Driver>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => 1))
            .ForMember(dest => dest.AddedDate, opt => opt.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.UpdateDate, opt => opt.MapFrom(src => DateTime.UtcNow));

        CreateMap<UpdateDriverCommand, Driver>()
            .ForMember(dest => dest.UpdateDate, opt => opt.MapFrom(src => DateTime.Now));
    }
}
