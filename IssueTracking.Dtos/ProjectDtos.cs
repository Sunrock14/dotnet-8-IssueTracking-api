namespace IssueTracking.Dtos;


public sealed record ProjectGetDto(
    string Id,
    string Name,
    string Code,
    string Description);

public sealed record ProjectAddDto(
    string Name,
    string Code,
    string Description);

public sealed record ProjectUpdateDto(
    int Id,
    string Name,
    string Code,
    string Desription,
    DateTime UpdatedTime);
