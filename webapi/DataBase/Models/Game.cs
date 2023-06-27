namespace PirateGold.DataBase.Models;

public class Game
{
    public int GameId { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<CartridgeToGame> CartridgeGames { get; set; } = new List<CartridgeToGame>();
}