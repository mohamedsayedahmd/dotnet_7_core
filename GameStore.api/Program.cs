using GameStore.api.Endpoints;
using GameStore.api.Repositories;

var builder = WebApplication.CreateBuilder(args); // for services
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();


var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
