namespace PirateGold.DataBase.Models;

public class CartridgeToRom
{
    public int CartridgeId { get; set; }
    public Cartridge Cartridge { get; set; } = null!;
    public int RomId { get; set; }
    public Rom Rom { get; set; } = null!;
}