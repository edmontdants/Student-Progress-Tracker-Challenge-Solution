using AutoMapper;
using StudentProgress.Domain.Entities;
using StudentProgress.Application.DTOs;

namespace StudentProgress.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<Progress, ProgressDto>();
            CreateMap<ProgressCreateDto, Progress>();
        }
    }
}
