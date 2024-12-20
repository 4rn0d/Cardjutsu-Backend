using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Models;
using System.Reflection.Emit;

namespace Super_Cartes_Infinies.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public const string ADMIN_ROLE = "admin";

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        
        builder.Entity<Card>().HasData(Seed.SeedCards());
        builder.Entity<Player>().HasData(Seed.SeedTestPlayers());
        builder.Entity<IdentityUser>().HasData(Seed.SeedTestUsers());
        builder.Entity<Power>().HasData(Seed.SeedPower());

        builder.Entity<Config>().HasData(Seed.SeedConfigs());
        builder.Entity<CardStart>().HasData(Seed.SeedCardStarts());
        
        builder.Entity<IdentityUser>().HasData(Seed.SeedUsers());
        builder.Entity<IdentityRole>().HasData(Seed.SeedRoles());      
        
        builder.Entity<IdentityUserRole<string>>().HasData(Seed.SeedUserRoles());

        // Lorsque le modèle de données se complexifient, il faut éventuellement utiliser Fluent API
        // https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/fluent/types-and-properties
        // pour préciser certaines relations.
        // Nous allons couvrir ce sujet plus tard dans la session
        builder.Entity<Match>()
            .HasOne(m => m.PlayerDataA)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Match>()
            .HasOne(m => m.PlayerDataB)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);

        //DECKPLAYER
        builder.Entity<Deck>()
        .HasOne(e => e.Player)
        .WithMany()
        .OnDelete(DeleteBehavior.NoAction); // <--

        // Fin de Fluent API
    }

    public DbSet<Card> Cards { get; set; } = default!;

    public DbSet<Player> Players { get; set; } = default!;

    public DbSet<Match> Matches { get; set; } = default!;
    public DbSet<Deck> Decks { get; set; } = default!;

    public DbSet<OwnedCard> OwnedCards { get; set; } = default!;

    public DbSet<MatchPlayerData> MatchPlayersData { get; set; } = default!;

    public DbSet<Config> Config { get; set; } = default!;

    public DbSet<CardStart> CardStart { get; set; } = default!;

    public DbSet<Power> Power { get; set; } = default!;
}

