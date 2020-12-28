using Christ3D.Application.ViewModels;
using Christ3D.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Christ3D.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {

            CreateMap<Student, StudentViewModel>()
         .ForMember(d => d.County, o => o.MapFrom(s => s.Address.County))
         .ForMember(d => d.Province, o => o.MapFrom(s => s.Address.Province))
         .ForMember(d => d.City, o => o.MapFrom(s => s.Address.City))
         .ForMember(d => d.Street, o => o.MapFrom(s => s.Address.Street))
         ;

        }
    }
}
