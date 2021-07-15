using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace vac_master.Models
{
    public partial class covid19Context : DbContext
    {
        public covid19Context()
        {
        }

        public covid19Context(DbContextOptions<covid19Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Vacuna> Vacuna { get; set; }
        public virtual DbSet<Vacunados> Vacunados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;uid=root;database=covid19", x => x.ServerVersion("10.4.18-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona");

                entity.HasIndex(e => e.Cedula)
                    .HasName("Cedula")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnType("varchar(13)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FechaNac)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.ToTable("provincias");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Vacuna>(entity =>
            {
                entity.ToTable("vacuna");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.NombreVacuna)
                    .IsRequired()
                    .HasColumnName("Nombre_vacuna")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Vacunados>(entity =>
            {
                entity.ToTable("vacunados");

                entity.HasIndex(e => e.IdPersona)
                    .HasName("id_persona");

                entity.HasIndex(e => e.IdProvincia)
                    .HasName("id_provincia");

                entity.HasIndex(e => e.IdVacuna)
                    .HasName("id_vacuna");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("id_persona")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("id_provincia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVacuna)
                    .HasColumnName("id_vacuna")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Vacunados)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("vacunados_ibfk_1");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Vacunados)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("vacunados_ibfk_3");

                entity.HasOne(d => d.IdVacunaNavigation)
                    .WithMany(p => p.Vacunados)
                    .HasForeignKey(d => d.IdVacuna)
                    .HasConstraintName("vacunados_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
