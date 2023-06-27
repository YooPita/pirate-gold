namespace PirateGold.DataBase.Models;

public class Photo
{
    public int PhotoId { get; set; }
    public string Path { get; set; } = null!;
    public ICollection<CartridgeToPhoto> CartridgePhotos { get; set; } = new List<CartridgeToPhoto>();
}