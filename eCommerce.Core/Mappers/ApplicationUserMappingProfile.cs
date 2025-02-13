﻿using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.Mappers;

public class ApplicationUserMappingProfile : Profile
{
    //In this constructor we will write the code for mapping
    public ApplicationUserMappingProfile()
    {
        CreateMap<ApplicationUser, AuthenticationResponse>()
            .ForMember(dest => dest.UserId, opt =>
            opt.MapFrom(src => src.UserId))
            .ForMember(dest => dest.Email, opt =>
            opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.UserName, opt =>
            opt.MapFrom(src => src.UserName))
            .ForMember(dest => dest.Gender, opt =>
            opt.MapFrom(src => src.Gender))
            .ForMember(dest => dest.Success, opt =>
            opt.Ignore())
            .ForMember(dest => dest.Token, opt =>
            opt.Ignore()); // we've ignored last two fields because, as we can see in ApplicationUser we don't have Success and Token. So we have to ignore, it means we aren't going to assign any value while mapping is working.
    }
}

