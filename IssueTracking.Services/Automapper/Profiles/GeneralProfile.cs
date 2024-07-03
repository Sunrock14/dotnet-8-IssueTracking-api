using AutoMapper;
using IssueTracking.Dtos;
using IssueTracking.Entities.Models;

namespace IssueTracking.Services.Automapper.Profiles;

public class GeneralProfile : Profile
{
    public GeneralProfile()
    {
        CreateMap<Project, ProjectAddDto>();
        CreateMap<Project, ProjectUpdateDto>()
            .ForMember(opt => opt.UpdatedTime, opt => opt.MapFrom(x => DateTime.Now)); // UpdateTime burada yapılıyor
        CreateMap<List<Project>, List<ProjectGetDto>>();
        CreateMap<Project, ProjectGetDto>();
    }
}
