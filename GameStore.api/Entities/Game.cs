namespace GameStore.api.Entities;

public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; }
    // public string? Name { get; set; }
    // = // string.Empty; //or = "some value";
    public required string Genre { get; set; } // kind
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public required string ImageUri { get; set; }
}