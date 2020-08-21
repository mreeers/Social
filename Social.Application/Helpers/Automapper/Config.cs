using AutoMapper;
using Social.Domain.Models;
using Social.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Application.Helpers.Automapper
{
    public class Config : Profile
    {
        public Config()
        {
            CreateMap<ChildDTO, PersonsSocial>();

            CreateMap<RepresentDTO, PersonsSocial>();

            CreateMap<ServisesDTO, ServisesSocial>();

            CreateMap<HolidayDTO, SocialSession>();
        }
    }
}
