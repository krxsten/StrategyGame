using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using strategy_game.Data.Models;

namespace strategy_game.Data;

public partial class StrategyGameContext : DbContext
{
    public StrategyGameContext()
    {
    }

    public StrategyGameContext(DbContextOptions<StrategyGameContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Battle> Battles { get; set; }

    public virtual DbSet<BattleUnit> BattleUnits { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<Faction> Factions { get; set; }

    public virtual DbSet<Map> Maps { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<PlayerBuilding> PlayerBuildings { get; set; }

    public virtual DbSet<PlayerFaction> PlayerFactions { get; set; }

    public virtual DbSet<PlayerLocation> PlayerLocations { get; set; }

    public virtual DbSet<PlayerResource> PlayerResources { get; set; }

    public virtual DbSet<PlayerTechnology> PlayerTechnologies { get; set; }

    public virtual DbSet<PlayerUnit> PlayerUnits { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<Technology> Technologies { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=STUDENT14;Initial Catalog=Strategy_Game;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Battle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Battles__3214EC0748E22E61");

            entity.Property(e => e.DefenderId).HasColumnName("DefenderId ");

            entity.HasOne(d => d.Attacker).WithMany(p => p.BattleAttackers)
                .HasForeignKey(d => d.AttackerId)
                .HasConstraintName("FK__Battles__Attacke__52593CB8");

            entity.HasOne(d => d.Defender).WithMany(p => p.BattleDefenders)
                .HasForeignKey(d => d.DefenderId)
                .HasConstraintName("FK__Battles__Defende__534D60F1");
        });

        modelBuilder.Entity<BattleUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BattleUn__3214EC07C4C3C337");

            entity.HasOne(d => d.Battle).WithMany(p => p.BattleUnits)
                .HasForeignKey(d => d.BattleId)
                .HasConstraintName("FK__BattleUni__Battl__5629CD9C");

            entity.HasOne(d => d.Player).WithMany(p => p.BattleUnits)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("FK__BattleUni__Playe__5812160E");

            entity.HasOne(d => d.Unit).WithMany(p => p.BattleUnits)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__BattleUni__UnitI__571DF1D5");
        });

        modelBuilder.Entity<Building>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Building__3214EC07754525B6");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Faction).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.FactionId)
                .HasConstraintName("FK__Buildings__Facti__3F466844");
        });

        modelBuilder.Entity<Faction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Factions__3214EC073C562BE5");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Map>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Maps__3214EC079168A302");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Players__3214EC0784028F71");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<PlayerBuilding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlayerBu__3214EC07EA38B26F");

            entity.HasOne(d => d.Building).WithMany(p => p.PlayerBuildings)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK__PlayerBui__Build__4316F928");

            entity.HasOne(d => d.Player).WithMany(p => p.PlayerBuildings)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("FK__PlayerBui__Playe__4222D4EF");
        });

        modelBuilder.Entity<PlayerFaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlayerFa__3214EC0747B2B60B");

            entity.HasOne(d => d.Faction).WithMany(p => p.PlayerFactions)
                .HasForeignKey(d => d.FactionId)
                .HasConstraintName("FK__PlayerFac__Facti__3C69FB99");

            entity.HasOne(d => d.Player).WithMany(p => p.PlayerFactions)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("FK__PlayerFac__Playe__3B75D760");
        });

        modelBuilder.Entity<PlayerLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlayerLo__3214EC0776D0A61C");

            entity.HasOne(d => d.Map).WithMany(p => p.PlayerLocations)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("FK__PlayerLoc__MapId__5DCAEF64");

            entity.HasOne(d => d.Player).WithMany(p => p.PlayerLocations)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("FK__PlayerLoc__Playe__5CD6CB2B");
        });

        modelBuilder.Entity<PlayerResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlayerRe__3214EC07D96A291F");

            entity.HasOne(d => d.Player).WithMany(p => p.PlayerResources)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("FK__PlayerRes__Playe__4E88ABD4");

            entity.HasOne(d => d.Resource).WithMany(p => p.PlayerResources)
                .HasForeignKey(d => d.ResourceId)
                .HasConstraintName("FK__PlayerRes__Resou__4F7CD00D");
        });

        modelBuilder.Entity<PlayerTechnology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlayerTe__3214EC07758915C4");

            entity.Property(e => e.IsResearched).HasMaxLength(100);

            entity.HasOne(d => d.Player).WithMany(p => p.PlayerTechnologies)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("FK__PlayerTec__Playe__628FA481");

            entity.HasOne(d => d.Technology).WithMany(p => p.PlayerTechnologies)
                .HasForeignKey(d => d.TechnologyId)
                .HasConstraintName("FK__PlayerTec__Techn__6383C8BA");
        });

        modelBuilder.Entity<PlayerUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlayerUn__3214EC07D5BCA3A9");

            entity.Property(e => e.UnitId).HasColumnName("UnitId ");

            entity.HasOne(d => d.Player).WithMany(p => p.PlayerUnits)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("FK__PlayerUni__Playe__48CFD27E");

            entity.HasOne(d => d.Unit).WithMany(p => p.PlayerUnits)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__PlayerUni__UnitI__49C3F6B7");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Resource__3214EC0705626AAB");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Technology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Technolo__3214EC074435ADD0");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Units__3214EC0779A5F27C");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Faction).WithMany(p => p.Units)
                .HasForeignKey(d => d.FactionId)
                .HasConstraintName("FK__Units__FactionId__45F365D3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
