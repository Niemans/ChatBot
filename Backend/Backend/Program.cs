using Backend.endpoints.helpers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseHttpsRedirection();

var count = EndpointSetter.SetEndpoints(app);
Console.WriteLine($"{count} endpoints set");

app.Run();
