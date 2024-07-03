using IssueTracking.Core.Response;
using IssueTracking.Dtos;

namespace IssueTracking.Services.Businesses.Projects;

public interface IProjectService
{
    Task<IDataResponse<ProjectAddDto>> AddProjectAsync(ProjectAddDto projectAddDto);
    Task<IDataResponse<ProjectUpdateDto>> UpdateProjectAsync(ProjectUpdateDto projectUpdateDto);
    Task<IDataResponse<ProjectGetDto>> GetAsync(int Id);
    Task<IDataResponse<List<ProjectGetDto>>> GetAllAsync();
}
