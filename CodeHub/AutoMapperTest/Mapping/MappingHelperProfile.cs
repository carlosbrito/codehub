using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperTest.Mapping
{
    public class MappingHelperProfile : Profile
    {

        public MappingHelperProfile()
        {
            //CreateMap<Model.UserDomainViewModel, Model.UserDomain>().ReverseMap();
            CreateMap<Model.UserDomainViewModel, Model.UserDomain>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.nome));
        }
    }
}
