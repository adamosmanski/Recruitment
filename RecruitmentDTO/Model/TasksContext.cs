using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RecruitmentDTO.Model;

public partial class TasksContext : DbContext
{
    public TasksContext()
    {
    }

    public TasksContext(DbContextOptions<TasksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Osoby> Osobies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Tasks;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Osoby>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Osoby");

            entity.Property(e => e.IdMatki).HasColumnName("id_matki");
            entity.Property(e => e.IdOjca).HasColumnName("id_ojca");
            entity.Property(e => e.IdOsoby)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_osoby");
            entity.Property(e => e.Imie)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("imie");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nazwisko");
            entity.Property(e => e.Plec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("plec");
            entity.Property(e => e.RokUrodzenia)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("rok_urodzenia");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
