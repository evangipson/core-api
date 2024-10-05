using AutoMapper;

using CoreApi.Platform.Domain.DTOs;
using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Logic.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            _ = CreateMap<UserSystemUserData, User>()
                .ForMember(src => src.Id, opts => opts.MapFrom(dest => Guid.NewGuid()))
                .ForMember(src => src.Street, opts => opts.MapFrom(dest => dest.Address!.Street ?? string.Empty))
                .ForMember(src => src.City, opts => opts.MapFrom(dest => dest.Address!.City ?? string.Empty))
                .ForMember(src => src.ZipCode, opts => opts.MapFrom(dest => dest.Address!.ZipCode ?? string.Empty))
                .ForMember(src => src.Latitude, opts => opts.MapFrom(dest => dest.Address!.Geo!.Lat))
                .ForMember(src => src.Longitude, opts => opts.MapFrom(dest => dest.Address!.Geo!.Lng))
                .ForMember(src => src.CompanyName, opts => opts.MapFrom(dest => dest.Company!.Name));
        }
    }
}
