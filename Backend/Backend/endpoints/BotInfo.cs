using Microsoft.AspNetCore.Mvc;

namespace Backend.endpoints;

public class BotInfo : IEndpoint
{
    public string Pattern { get; }
    public WebApplication App { get; }

    public BotInfo(WebApplication app, string pattern)
    {
        Pattern = pattern;
        App = app;

        app.MapGet(Pattern, GetBotInfo);
        app.MapPatch(Pattern, SetBotInfo);
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