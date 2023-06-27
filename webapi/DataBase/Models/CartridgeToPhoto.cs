namespace PirateGold.DataBase.Models;

public class CartridgeToPhoto
{
    public int CartridgeId { get; set; }
    public Cartridge Cartridge { get; set; } = null!;
    public int PhotoId { get; set; }
    public Photo Photo { get; set; } = null!;
}