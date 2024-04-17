using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Esercitazione17Aprile.Models;

public partial class Esercitazione17AprileContext : DbContext
{
    public Esercitazione17AprileContext()
    {
    }

    public Esercitazione17AprileContext(DbContextOptions<Esercitazione17AprileContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cittum> Citta { get; set; }

    public virtual DbSet<Impiegato> Impiegatos { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Reparto> Repartos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-11\\SQLEXPRESS;Database=Esercitazione17Aprile;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cittum>(entity =>
        {
            entity.HasKey(e => e.CittaId).HasName("PK__citta__3EF53F31816B5300");

            entity.ToTable("citta");

            entity.HasIndex(e => e.NomeCitta, "UQ__citta__502E5D18EF2CD1FD").IsUnique();

            entity.Property(e => e.CittaId).HasColumnName("cittaID");
            entity.Property(e => e.NomeCitta)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nome_citta");
            entity.Property(e => e.ProvinciaRif).HasColumnName("provinciaRIF");

            entity.HasOne(d => d.ProvinciaRifNavigation).WithMany(p => p.Citta)
                .HasForeignKey(d => d.ProvinciaRif)
                .HasConstraintName("FK__citta__provincia__48CFD27E");
        });

        modelBuilder.Entity<Impiegato>(entity =>
        {
            entity.HasKey(e => e.ImpiegatoId).HasName("PK__impiegat__C7A20D126FE58E88");

            entity.ToTable("impiegato");

            entity.HasIndex(e => e.Matricola, "UQ__impiegat__2C2751BA86FE0DBF").IsUnique();

            entity.Property(e => e.ImpiegatoId).HasColumnName("impiegatoID");
            entity.Property(e => e.CittaRif)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cittaRIF");
            entity.Property(e => e.CognomeImpiegato)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("cognome_impiegato");
            entity.Property(e => e.DataNascitaImpiegato).HasColumnName("data_nascita_impiegato");
            entity.Property(e => e.IndirizzoImpiegato)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("indirizzo_impiegato");
            entity.Property(e => e.Matricola)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("matricola");
            entity.Property(e => e.NomeImpiegato)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nome_impiegato");
            entity.Property(e => e.RepartoRif).HasColumnName("repartoRIF");
            entity.Property(e => e.RuoloImpiegato)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ruolo_impiegato");

            entity.HasOne(d => d.RepartoRifNavigation).WithMany(p => p.Impiegatos)
                .HasForeignKey(d => d.RepartoRif)
                .HasConstraintName("FK__impiegato__citta__4CA06362");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.ProvinciaId).HasName("PK__provinci__671F1345BDDAAFBF");

            entity.ToTable("provincia");

            entity.HasIndex(e => e.Sigla, "UQ__provinci__3C47D51953FEDD9A").IsUnique();

            entity.Property(e => e.ProvinciaId).HasColumnName("provinciaID");
            entity.Property(e => e.Sigla)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("sigla");
        });

        modelBuilder.Entity<Reparto>(entity =>
        {
            entity.HasKey(e => e.RepartoId).HasName("PK__reparto__612C4F36CF2D2D32");

            entity.ToTable("reparto");

            entity.Property(e => e.RepartoId).HasColumnName("repartoID");
            entity.Property(e => e.NomeReparto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome_reparto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
