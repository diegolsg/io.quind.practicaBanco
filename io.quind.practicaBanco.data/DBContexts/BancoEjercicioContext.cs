using System;
using System.Collections.Generic;
using io.quind.practicaBanco.entity.ClientesEntities;
using io.quind.practicaBanco.entity.CuentasEntiies;
using io.quind.practicaBanco.entity.TransaccionesEntities;
using Microsoft.EntityFrameworkCore;

namespace io.quind.practicaBanco.data.DBContexts;

public partial class BancoEjercicioContext : DbContext
{
    public BancoEjercicioContext()
    {
    }

    public BancoEjercicioContext(DbContextOptions<BancoEjercicioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClienteEntidad> ClienteEntidads { get; set; }

    public virtual DbSet<CuentaEntidad> CuentaEntidads { get; set; }

    public virtual DbSet<TransaccionEntidad> TransaccionEntidads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Integrated Security=SSPI;Initial Catalog=BancoEjercicio;Data Source=LAPTOP-ADDS55V9\\SQLSERVER; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClienteEntidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClienteE__3213E83F23DB729A");

            entity.ToTable("ClienteEntidad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaActualizacionRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_actualizacion_registro");
            entity.Property(e => e.FechaCreacionRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion_registro");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("date")
                .HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroIdentificacion).HasColumnName("numero_identificacion");
            entity.Property(e => e.TiposIdentificacion).HasColumnName("tipos_identificacion");
        });

        modelBuilder.Entity<CuentaEntidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CuentaEn__3213E83F54A18EB9");

            entity.ToTable("CuentaEntidad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.EstadoCuenta).HasColumnName("estado_cuenta");
            entity.Property(e => e.ExentoGmf).HasColumnName("exento_GMF");
            entity.Property(e => e.FechaActualizacionCuenta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_actualizacion_cuenta");
            entity.Property(e => e.FechaCreacionCuenta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion_cuenta");
            entity.Property(e => e.NumeroCuenta).HasColumnName("numero_cuenta");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("saldo");
            entity.Property(e => e.TipoCuenta).HasColumnName("tipo_cuenta");

            entity.HasOne(d => d.Cliente).WithMany(p => p.CuentaEntidads)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentaEnt__clien__3D5E1FD2");
        });

        modelBuilder.Entity<TransaccionEntidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transacc__3213E83F628D6056");

            entity.ToTable("TransaccionEntidad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CuentaDestino)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("cuenta_destino");
            entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");
            entity.Property(e => e.FechaTransaccion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_transaccion");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("monto");

            entity.HasOne(d => d.Cuenta).WithMany(p => p.TransaccionEntidads)
                .HasForeignKey(d => d.CuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacci__cuent__412EB0B6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
