namespace PirateGold.DataBase.Models;

public class Rom
{
    public int RomId { get; set; }
    public string? Name { get; set; }
    public string Path { get; set; } = null!;
    public string Hash { get; set; } = null!;
    public ICollection<CartridgeToRom> CartridgeRoms { get; set; } = new List<CartridgeToRom>();
}