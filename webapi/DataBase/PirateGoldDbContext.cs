using Microsoft.EntityFrameworkCore;
using PirateGold.DataBase.Models;

namespace PirateGold.DataBase;

public class PirateGoldDbContext : DbContext
{
    public PirateGoldDbContext(DbContextOptions<PirateGoldDbContext> options) :
        base(options)
    {
    }

    public DbSet<Cartridge> Cartridges { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<CartridgePublisher> CartridgePublishers { get; set; }
    public DbSet<CartridgeType> CartridgeTypes { get; set; }
    public DbSet<CartridgeToGame> CartridgeGame { get; set; }
    public DbSet<CartridgeToRom> CartridgeRom { get; set; }
    public DbSet<Rom> Roms { get; set; }
    public DbSet<CartridgeToPhoto> CartridgePhoto { get; set; }
    public DbSet<Photo> Photos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CartridgeToGame>()
            .HasKey(cpg => new { cpg.GameId, cpg.CartridgeId });
        modelBuilder.Entity<CartridgeToGame>()
            .HasOne(cpg => cpg.Game)
            .WithMany(pg => pg.CartridgeGames)
            .HasForeignKey(c => c.GameId);
        modelBuilder.Entity<CartridgeToGame>()
            .HasOne(cpg => cpg.Cartridge)
            .WithMany(pg => pg.CartridgeGames)
            .HasForeignKey(c => c.CartridgeId);


        modelBuilder.Entity<CartridgeToPhoto>()
            .HasKey(cpg => new { cpg.PhotoId, cpg.CartridgeId });
        modelBuilder.Entity<CartridgeToPhoto>()
            .HasOne(cpg => cpg.Photo)
            .WithMany(pg => pg.CartridgePhotos)
            .HasForeignKey(c => c.PhotoId);
        modelBuilder.Entity<CartridgeToPhoto>()
            .HasOne(cpg => cpg.Cartridge)
            .WithMany(pg => pg.CartridgePhotos)
            .HasForeignKey(c => c.CartridgeId);


        modelBuilder.Entity<CartridgeToRom>()
            .HasKey(cpg => new { cpg.RomId, cpg.CartridgeId });
        modelBuilder.Entity<CartridgeToRom>()
            .HasOne(cpg => cpg.Rom)
            .WithMany(pg => pg.CartridgeRoms)
            .HasForeignKey(c => c.RomId);
        modelBuilder.Entity<CartridgeToRom>()
            .HasOne(cpg => cpg.Cartridge)
            .WithMany(pg => pg.CartridgeRoms)
            .HasForeignKey(c => c.CartridgeId);
    }
}