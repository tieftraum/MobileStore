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
            CreateMap<MobilePhoneResource, MobilePhone>().ReverseMap();

            //.formember(c => c.cpuname, c => c.mapfrom(o => o.cpu.cpuname))
            //.formember(c => c.manufacturername, c => c.mapfrom(o => o.manufacturer.name))
            //.formember(c => c.operatingsystemname, c => c.mapfrom(o => o.operatingsystem.operatingsystemname));

        }
    }
}
