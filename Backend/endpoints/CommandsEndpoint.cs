using Microsoft.AspNetCore.Mvc;

namespace Backend.endpoints;

public record CommandsEndpoint(WebApplication App) : IEndpoint
{
    public string Pattern => "/commands";

    private static List<string> GetCommands()
    {
        return ["a", "s", "d", "f"];
    }

    private static void SetCommands([FromBody] List<string> commands)
    {
        Console.WriteLine(string.Join(", ", commands));
    }


    public void Set()
    {
        App.MapGet(Pattern, GetCommands);
        App.MapPatch(Pattern, SetCommands);
    }
}