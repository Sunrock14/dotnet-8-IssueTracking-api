using AutoMapper;
using IssueTracking.Core.Response;
using IssueTracking.Data.UnitOfWork;
using IssueTracking.Dtos;
using IssueTracking.Entities.Models;
using IssueTracking.Services.Helpers;

namespace IssueTracking.Services.Businesses.Projects;

public class ProjectManager : _BaseManager, IProjectService
{
    public ProjectManager(IMapper? mapper, IUnitOfWork? unitOfWork) : base(mapper, unitOfWork)
    {
    }

    public async Task<IDataResponse<ProjectAddDto>> AddProjectAsync(ProjectAddDto projectAddDto)
    {
        if (projectAddDto == null) return new DataResponse<ProjectAddDto>(400,Messages.General.Error,projectAddDto);
        var mappedProject = Mapper.Map<Project>(projectAddDto);
        var project = await UnitOfWork.Project.AddAsync(mappedProject);
        await UnitOfWork.SaveAsync();
        return new DataResponse<ProjectAddDto>(200, Messages.General.Success, projectAddDto);
    }

    public async Task<IDataResponse<List<ProjectGetDto>>> GetAllAsync()
    {
        var listProject = await UnitOfWork.Project.GetAllAsync();
        var mappedProject = Mapper.Map<IList<Project>, List<ProjectGetDto>>(listProject);
        if (listProject == null) return new DataResponse<List<ProjectGetDto>>(400, Messages.General.Error, mappedProject);
        return new DataResponse<List<ProjectGetDto>>(200, Messages.General.Success, mappedProject);

    }

    public async Task<IDataResponse<ProjectGetDto>> GetAsync(int Id)
    {
        var project = await UnitOfWork.Project.GetAsync(x => x.Id == Id);
        var mappedProject = Mapper.Map<Project, ProjectGetDto>(project);
        if(project == null) return new DataResponse<ProjectGetDto>(400, Messages.General.NotFound(false), mappedProject);
        return new DataResponse<ProjectGetDto>(200, Messages.General.Success, mappedProject);
    }

    public async Task<IDataResponse<ProjectUpdateDto>> UpdateProjectAsync(ProjectUpdateDto projectUpdateDto)
    {
        if (projectUpdateDto == null) return new DataResponse<ProjectUpdateDto>(400, Messages.General.Error, projectUpdateDto);
        var oldProject = await UnitOfWork.Project.GetAsync(x => x.Id == projectUpdateDto.Id);
        if(oldProject == null) return new DataResponse<ProjectUpdateDto>(400, Messages.General.NotFound(false), projectUpdateDto);
        var updatedProject = Mapper.Map<ProjectUpdateDto, Project>(projectUpdateDto, oldProject);
        await UnitOfWork.Project.UpdateAsync(updatedProject);
        await UnitOfWork.SaveAsync();
        return new DataResponse<ProjectUpdateDto>(200, Messages.General.Success, projectUpdateDto);
    }
}
