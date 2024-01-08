using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MegaCasting.Class;

public partial class DbMegacastingContext : DbContext
{
    public DbMegacastingContext()
    {
    }

    public DbMegacastingContext(DbContextOptions<DbMegacastingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Partner> Partners { get; set; }
    public virtual DbSet<Annouce> Annouces { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=db_megacasting;user=root;password=;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.BirhDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Firstname).HasMaxLength(75);
            entity.Property(e => e.Lastname).HasMaxLength(75);
            entity.Property(e => e.Password).HasMaxLength(256);
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("partners");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Label).HasMaxLength(100);
            entity.Property(e => e.SIRET).HasMaxLength(14);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.DateTime).HasColumnType("datetime");


        });

        modelBuilder.Entity<Annouce>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("annouces");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.Content).HasMaxLength(14);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
