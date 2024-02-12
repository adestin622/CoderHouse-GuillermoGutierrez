using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaGestionDataEntities.Entidades;

namespace SistemaGestionDataEntities.Database;

public partial class SGestionContext : DbContext
{
    public SGestionContext()
    {
    }

    public SGestionContext(DbContextOptions<SGestionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoVendido> ProductoVendidos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=GUILLERMO\\SQLCODERHOUSE; Database=coderhouse; Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Producto");

            entity.Property(e => e.Costo).HasColumnType("money");
            entity.Property(e => e.Descripciones).IsUnicode(false);
            entity.Property(e => e.PrecioVenta).HasColumnType("money");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientCascade)
                .HasConstraintName("FK_Producto_Usuario");
        });

        modelBuilder.Entity<ProductoVendido>(entity =>
        {
            entity.ToTable("ProductoVendido");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductoVendidos)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__ProductoV__IdPro__412EB0B6");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.ProductoVendidos)
                .HasForeignKey(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientCascade)
                .HasConstraintName("FK_ProductoVendido_Venta");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario");

            entity.Property(e => e.Apellido).IsUnicode(false);
            entity.Property(e => e.Contraseña).IsUnicode(false);
            entity.Property(e => e.Mail).IsUnicode(false);
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.NombreUsuario).IsUnicode(false);
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.Property(e => e.Comentarios).IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientCascade)
                .HasConstraintName("FK_Venta_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
