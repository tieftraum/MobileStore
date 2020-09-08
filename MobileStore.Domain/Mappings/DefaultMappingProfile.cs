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
            CreateMap<MobilePhoneResource, MobilePhone>();

            //Domainto  API resources  
            CreateMap<MobilePhone, MobilePhoneResource>();
        }
    }
}
