using AutoMapper;
using IssueTracking.Data.UnitOfWork;

namespace IssueTracking.Services.Businesses;

public class _BaseManager
{
    private readonly IUnitOfWork? UnitOfWork;
    private readonly IMapper? Mapper;

    public _BaseManager(IMapper? mapper, IUnitOfWork? unitOfWork)
    {
        Mapper = mapper;
        UnitOfWork = unitOfWork;
    }
}
