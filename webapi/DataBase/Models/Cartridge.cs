namespace PirateGold.DataBase.Models;

public class Cartridge
{
    public int CartridgeId { get; set; }
    public string Name { get; set; } = null!;
    public string Catalog { get; set; } = null!;
    public string Description { get; set; } = null!;
    public CartridgePublisher? CartridgePublisher { get; set; }
    public CartridgeType? CartridgeType { get; set; }
    public ICollection<CartridgeToGame> CartridgeGames { get; set; } = new List<CartridgeToGame>();
    public ICollection<CartridgeToRom> CartridgeRoms { get; set; } = new List<CartridgeToRom>();
    public ICollection<CartridgeToPhoto> CartridgePhotos { get; set; } = new List<CartridgeToPhoto>();
}