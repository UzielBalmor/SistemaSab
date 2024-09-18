using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SERVIDOR.models;

public partial class BlazorContext : DbContext
{
    public BlazorContext()
    {
    }

    public BlazorContext(DbContextOptions<BlazorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dato> Datos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){ }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dato>(entity =>
        {
            entity.HasKey(e => e.Iddatos).HasName("PK__DATOS__77904A88983C582E");

            entity.ToTable("DATOS");

            entity.Property(e => e.Iddatos).HasColumnName("IDDATOS");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_MATERNO");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_PATERNO");
            entity.Property(e => e.Calle)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CONTRASEÑA");
            entity.Property(e => e.Correo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Curp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CURP");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCALIDAD");
            entity.Property(e => e.Municipio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MUNICIPIO");
            entity.Property(e => e.Ne).HasColumnName("NE");
            entity.Property(e => e.Ni).HasColumnName("NI");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAIS");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.Datos)
                .HasForeignKey(d => d.Idusuario)
                .HasConstraintName("FK__DATOS__IDUSUARIO__48CFD27E");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Idusuario).HasName("PK__USUARIOS__98242AA99CEA2B27");

            entity.ToTable("USUARIOS");

            entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIPO_USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
