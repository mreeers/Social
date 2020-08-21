using AutoMapper;
using Shop.Domain.Models;
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

            CreateMap<HolidayDTO, SocialDelivery>()
                .ForMember(delivery => delivery.Id, dto =>
                {
                    dto.MapFrom(src => src.DeliveryId);
                })
                .ForMember(delivery => delivery.Method, dto =>
                {
                    dto.MapFrom(src => src.DeliveryMethod);
                });
            CreateMap<HolidayDTO, SocialPeriod>()
                .ForMember(period => period.Id, dto =>
                {
                    dto.MapFrom(src => src.PeriodId);
                })
                .ForMember(period => period.Name, dto =>
                {
                    dto.MapFrom(src => src.PeriodName);
                })
                .ForMember(period => period.IsActive, dto =>
                {
                    dto.MapFrom(src => src.PeriodIsActive);
                })
                .ForMember(period => period.PeriodBegin, dto =>
                {
                    dto.MapFrom(src => src.PeriodBegin);
                })
                .ForMember(period => period.PeriodEnd, dto =>
                {
                    dto.MapFrom(src => src.PeriodEnd);
                });
            CreateMap<HolidayDTO, SocialPlace>()
                .ForMember(place => place.Id, dto =>
                {
                    dto.MapFrom(src => src.PlaceId);
                })
                .ForMember(place => place.Name, dto =>
                {
                    dto.MapFrom(src => src.PlaceName);
                })
                .ForMember(place => place.Comments, dto =>
                {
                    dto.MapFrom(src => src.PlaceComments);
                });
            CreateMap<HolidayDTO, SocialWay>()
                .ForMember(way => way.Id, dto =>
                {
                    dto.MapFrom(src => src.WayId);
                })
                .ForMember(way => way.Name, dto =>
                {
                    dto.MapFrom(src => src.WayName);
                });
        }
    }
}
