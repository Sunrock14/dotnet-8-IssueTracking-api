namespace IssueTracking.Core.Response;

public interface IDataResponse<out T>
{
    public T Data { get; }
    public int StatusCode { get; }
    public string Message { get; }
    public Exception Exception { get; }

}
