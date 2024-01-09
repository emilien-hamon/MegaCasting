// Importation des espaces de noms nécessaires pour le programme
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

// Déclaration du namespace MegaCasting.Class
namespace MegaCasting.Class
{
    // Déclaration partielle de la classe DbMegacastingContext héritant de DbContext
    public partial class DbMegacastingContext : DbContext
    {
        // Constructeur par défaut de la classe
        public DbMegacastingContext()
        {
        }

        // Constructeur avec options de configuration de DbContext
        public DbMegacastingContext(DbContextOptions<DbMegacastingContext> options)
            : base(options)
        {
        }

        // Déclaration des DbSet pour chaque entité dans la base de données
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Annouce> Annouces { get; set; }

        // Configuration de DbContext pour spécifier la connexion à la base de données
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Avertissement concernant la protection des informations sensibles dans la chaîne de connexion
            // Le lien fourni donne des conseils sur la façon de stocker en toute sécurité les chaînes de connexion
            optionsBuilder.UseMySQL("Server=localhost;Database=db_megacasting;user=root;password=;convert zero datetime=true");
        }

        // Méthode de configuration du modèle de données
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration de l'entité User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("users");

                // Configuration des propriétés de l'entité User
                entity.Property(e => e.Id).HasColumnType("int(11)").HasColumnName("ID");
                entity.Property(e => e.BirhDate).HasColumnType("datetime");
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Firstname).HasMaxLength(75);
                entity.Property(e => e.Lastname).HasMaxLength(75);
                entity.Property(e => e.Password).HasMaxLength(256);
            });

            // Configuration de l'entité Partner
            modelBuilder.Entity<Partner>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.ToTable("partners");

                // Configuration des propriétés de l'entité Partner
                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.Label).HasMaxLength(100);
                entity.Property(e => e.SIRET).HasMaxLength(14);
                entity.Property(e => e.Description).HasMaxLength(100);
                entity.Property(e => e.DateTime).HasColumnType("datetime");
            });

            // Configuration de l'entité Annouce
            modelBuilder.Entity<Annouce>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.ToTable("annouces");

                // Configuration des propriétés de l'entité Annouce
                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.Title).HasMaxLength(100);
                entity.Property(e => e.Content).HasMaxLength(14);
            });

            // Appel à une méthode partielle pour compléter la configuration du modèle
            OnModelCreatingPartial(modelBuilder);
        }

        // Méthode partielle pour compléter la configuration du modèle
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
