using AutoMapper;
using MobileStore.Domain.Models;
using MobileStore.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Mappings
{
    public class DefaultMappingProfile : Profile
    {
        public DefaultMappingProfile()
        {
            // API resources to Domain and vice versa
            CreateMap<MobilePhoneResource, MobilePhone>().ReverseMap()
                .ForMember(c => c.CPUId, c => c.MapFrom(o => o.CPUId))
                .ForMember(c => c.ManufacturerId, c => c.MapFrom(o => o.ManufacturerId))
                .ForMember(c => c.MyOperatingSystemId, c => c.MapFrom(o => o.MyOperatingSystemId));
        }
    }
}
