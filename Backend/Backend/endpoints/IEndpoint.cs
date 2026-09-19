namespace Backend.endpoints;

public interface IEndpoint
{
    string Pattern { get; }
    WebApplication App { get; }
}