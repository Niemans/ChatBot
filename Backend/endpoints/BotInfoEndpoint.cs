using Microsoft.AspNetCore.Mvc;

namespace Backend.endpoints;

public record BotInfoEndpoint(WebApplication App) : IEndpoint
{
    public string Pattern => "/bot-info";

    public void Set()
    {
        App.MapGet(Pattern, GetBotInfo);
        App.MapPatch(Pattern, SetBotInfo);
    }

    private static void GetBotInfo()
    {
        Console.WriteLine( "Hello World!" );
    }

    private static void SetBotInfo([FromBody] string text)
    {
        Console.WriteLine(text);
    }
}