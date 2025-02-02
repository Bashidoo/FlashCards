using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GruppFlashCards.Models;

public partial class BusherSundayContext : DbContext
{
    public BusherSundayContext()
    {
    }

    public BusherSundayContext(DbContextOptions<BusherSundayContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<FlashCard> FlashCards { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-6O16HQII\\SQLEXPRESS;Database=busherSunday;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2BEE642A3C");

            entity.HasIndex(e => e.CategoryName, "UQ__Categori__8517B2E06FFCDCA2").IsUnique();

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        modelBuilder.Entity<FlashCard>(entity =>
        {
            entity.HasKey(e => e.FlashCardId).HasName("PK__FlashCar__12D764125A6B8F73");

            entity.Property(e => e.FlashCardId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FlashCardID"); // Allow EF Core to auto-generate IDs if applicable

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.FlashCardAnswer).HasMaxLength(255);
            entity.Property(e => e.FlashCardDescription).HasMaxLength(255);
            entity.Property(e => e.FlashCardName).HasMaxLength(100);
            entity.Property(e => e.FlashCardQuestion).HasMaxLength(255);

            entity.HasOne(d => d.Category)
                .WithMany(p => p.FlashCards)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FlashCard__Categ__3E52440B");

            // Explicitly tell EF Core to use properties instead of the constructor
            entity.Metadata.SetPropertyAccessMode(PropertyAccessMode.PreferFieldDuringConstruction);
        });


        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC9B62C2E4");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534065745F8").IsUnique();

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
