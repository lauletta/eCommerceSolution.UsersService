﻿using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;

namespace eCommerce.Core.Mappers;

public class RegisterRequestMappingProfile : Profile
{
    public RegisterRequestMappingProfile()
    {
        CreateMap<RegisterRequest, ApplicationUser>()
            .ForMember(dest => dest.UserId, opt =>
            opt.Ignore())
            .ForMember(dest => dest.Email, opt =>
            opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Password, opt =>
            opt.MapFrom(src => src.Password))
            .ForMember(dest => dest.UserName, opt =>
            opt.MapFrom(src => src.UserName))
            .ForMember(dest => dest.Gender, opt =>
            opt.MapFrom(src => src.Gender));
    }
}

