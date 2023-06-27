namespace PirateGold.DataBase.Models;

public class CartridgeToGame
{
    public int CartridgeId { get; set; }
    public Cartridge Cartridge { get; set; } = null!;
    public int GameId { get; set; }
    public Game Game { get; set; } = null!;
}