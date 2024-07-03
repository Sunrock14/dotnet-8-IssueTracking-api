using AutoMapper;
using IssueTracking.Data.UnitOfWork;

namespace IssueTracking.Services.Businesses;

public class _BaseManager
{
    public readonly IUnitOfWork? UnitOfWork;
    public readonly IMapper? Mapper;

    public _BaseManager(IMapper? mapper, IUnitOfWork? unitOfWork)
    {
        Mapper = mapper;
        UnitOfWork = unitOfWork;
    }
}
