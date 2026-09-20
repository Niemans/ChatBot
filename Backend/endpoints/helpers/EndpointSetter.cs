using System.Reflection;

namespace Backend.endpoints.helpers;

public static class EndpointSetter
{
    public static int SetEndpoints(WebApplication app)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var types = assembly
            .GetTypes()
            .Where(type => typeof(IEndpoint).IsAssignableFrom(type) && type is { IsInterface: false, IsAbstract: false })
            .ToList();

        var count = 0;
        foreach (var type in types)
        {
            if (Activator.CreateInstance(type, args:[app]) is not IEndpoint endpoint) continue;
            count++;
            endpoint.Set();
        }
        return count;
    }
}