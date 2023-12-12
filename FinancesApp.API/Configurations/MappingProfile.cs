using AutoMapper;
using FinancesApp.API.Models;
using FinancesApp.API.Models.DTOs;
using FinancesApp.API.Models.TOs;

namespace FinancesApp.API.Configurations;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AddFinanceDTO, Finance>()
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.TransactionType, opt => opt.MapFrom(src => src.TransactionType))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));

        CreateMap<Finance, FinanceTO>();
    }
    
    
}