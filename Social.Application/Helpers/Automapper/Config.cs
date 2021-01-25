using AutoMapper;
using Social.Domain.Models;
using Social.Domain.DTOs;

namespace Social.Application.Helpers.Automapper
{
    public class Config : Profile
    {
        public Config()
        {
            CreateMap<ChildDTO, PersonsSocial>()
                .ForMember(dest => dest.Surname, opt =>
                {
                    opt.MapFrom(src => src.SurnameChild);
                })
                .ForMember(dest => dest.Name, opt =>
                {
                    opt.MapFrom(src => src.NameChild);
                })
                .ForMember(dest => dest.Patronymic, opt =>
                {
                    opt.MapFrom(src => src.PatronymicChild);
                }).ReverseMap();

            CreateMap<RepresentDTO, PersonsSocial>()
                .ForMember(dest => dest.Surname, opt =>
                {
                    opt.MapFrom(src => src.SurnameRepresent);
                })
                .ForMember(dest => dest.Name, opt =>
                {
                    opt.MapFrom(src => src.NameRepresent);
                })
                .ForMember(dest => dest.Patronymic, opt =>
                {
                    opt.MapFrom(src => src.PatronymicRepresent);
                });

            CreateMap<ServisesDTO, ServisesSocial>();
            CreateMap<ServisesSocial, ServisesDTO>();

            CreateMap<HolidayDTO, SocialSession>();
        }
    }
}
