using GameStore.api.Entities;
using GameStore.api.Repositories;

namespace GameStore.api.Endpoints;

public static class GamesEndPoints
{
    
    const string GetGameEndpointName = "GetGame";

    public static RouteGroupBuilder MapGamesEndpoints(this IEndpointRouteBuilder routes)
    {
        // InMemGamesRepository repository = new();
        
        // WithParameterValidation - NuGet
        var group = routes.MapGroup("/games")
                       .WithParameterValidation();

        // Get Operation
        group.MapGet("/", (IGamesRepository repository) => repository.GetAll());

        group.MapGet("/{id}", (IGamesRepository repository,int id) =>
        {
            Game? game = repository.Get(id);
            return game is not null ? Results.Ok(game) : Results.NotFound();

        }).WithName(GetGameEndpointName); // provide a name for the endpoint

        // Post Operation
        group.MapPost("/", (IGamesRepository repository, Game game) =>
        {
            repository.Create(game);
            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);
        });

        // Put Operation
        group.MapPut("/{id}", (IGamesRepository repository,int id, Game updatedGame) =>
        {
            Game? existingGame = repository.Get(id);
            if (existingGame is null)
            {
                return Results.NotFound();
            }
            existingGame.Name = updatedGame.Name;
            existingGame.Genre = updatedGame.Genre;
            existingGame.Price = updatedGame.Price;
            existingGame.ReleaseDate = updatedGame.ReleaseDate;
            existingGame.ImageUri = updatedGame.ImageUri;

            repository.Update(existingGame);

            return Results.NoContent();
        });

        // Delete Operation
        group.MapDelete("/{id}", (IGamesRepository repository,int id) =>
        {

            Game? game = repository.Get(id);

            if (game is not null)
            {
                repository.Delete(id);
            }

            return Results.NoContent();

        });

        return group;

    }
}