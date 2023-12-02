using GameStore.api.Endpoints;

var builder = WebApplication.CreateBuilder(args); // for services
var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
