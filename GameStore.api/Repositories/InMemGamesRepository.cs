using GameStore.api.Entities;

namespace GameStore.api.Repositories;

public class InMemGamesRepository : IGamesRepository
{

    private readonly List<Game> games = new(){
    new Game(){
        Id = 1,
        Name = "Street Fighter II",
        Genre = "Fighting",
        Price = 19.99M,
        ReleaseDate = new DateTime(1991,2,1),
        ImageUri = "https://placehold.co/100"
    },
        new Game(){
        Id = 2,
        Name = "Final Fantasy XIV",
        Genre = "Roleplaying",
        Price = 59.99M,
        ReleaseDate = new DateTime(2010,9,30),
        ImageUri = "https://placehold.co/100"
    },
        new Game(){
        Id = 3,
        Name = "FIFA 23",
        Genre = "Sports",
        Price = 69.99M,
        ReleaseDate = new DateTime(2022,2,27),
        ImageUri = "https://placehold.co/100"
    },
};

    // IEnumerable -> represent list of objects
    public IEnumerable<Game> GetAll()
    {
        return games;
    }

    // find the game by id
    public Game? Get(int id)
    {
        return games.Find(game => game.Id == id);
    }

    // create new game
    public void Create(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    // update
    public void Update(Game updatedGame)
    {
        var index = games.FindIndex(game => game.Id == updatedGame.Id);
        games[index] = updatedGame;
    }

    // delete by id
    public void Delete(int id)
    {
        var index = games.FindIndex(game => game.Id == id);
        games.RemoveAt(index);
    }
}