using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Bitacora3dContext : DbContext
{
    public Bitacora3dContext()
    {
    }

    public Bitacora3dContext(DbContextOptions<Bitacora3dContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bitacoracambio> Bitacoracambios { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Foto> Fotos { get; set; }

    public virtual DbSet<Fotosmodelo3D> Fotosmodelo3Ds { get; set; }

    public virtual DbSet<Historialmantenimiento> Historialmantenimientos { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Mantenimiento> Mantenimientos { get; set; }

    public virtual DbSet<Perfil> Perfils { get; set; }

    public virtual DbSet<Pieza> Piezas { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Reparacione> Reparaciones { get; set; }

    public virtual DbSet<Tipocambio> Tipocambios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bitacoracambio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bitacora__3213E83FFC39473D");

            entity.ToTable("bitacoracambios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");

            entity.HasOne(d => d.Vehiculo).WithMany(p => p.Bitacoracambios)
                .HasForeignKey(d => d.VehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__bitacorac__vehic__2B3F6F97");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__clientes__885457EEAA5A21C3");

            entity.ToTable("clientes");

            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__comentar__3213E83FDCE0C1E2");

            entity.ToTable("comentarios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BitacoraId).HasColumnName("bitacora_id");
            entity.Property(e => e.Comentario1)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Bitacora).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.BitacoraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__comentari__bitac__534D60F1");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__comentari__usuar__5441852A");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Idfactura).HasName("PK__facturas__40FF55D8423C1D53");

            entity.ToTable("facturas");

            entity.Property(e => e.Idfactura).HasColumnName("idfactura");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Monto)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__facturas__monto__75A278F5");

            entity.HasOne(d => d.Vehiculo).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.VehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__facturas__vehicu__76969D2E");
        });

        modelBuilder.Entity<Foto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fotos__3213E83F4EECB21B");

            entity.ToTable("fotos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BitacoraId).HasColumnName("bitacora_id");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Enlace)
                .IsUnicode(false)
                .HasColumnName("enlace");
            entity.Property(e => e.Foto1)
                .IsUnicode(false)
                .HasColumnName("foto");

            entity.HasOne(d => d.Bitacora).WithMany(p => p.Fotos)
                .HasForeignKey(d => d.BitacoraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__fotos__bitacora___5CD6CB2B");
        });

        modelBuilder.Entity<Fotosmodelo3D>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fotosmod__3213E83FC8872CB8");

            entity.ToTable("fotosmodelo3D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Enlace)
                .IsUnicode(false)
                .HasColumnName("enlace");
            entity.Property(e => e.FechaSubida)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fecha_subida");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");

            entity.HasOne(d => d.Vehiculo).WithMany(p => p.Fotosmodelo3Ds)
                .HasForeignKey(d => d.VehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__fotosmode__vehic__66603565");
        });

        modelBuilder.Entity<Historialmantenimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__historia__3213E83FEE1328D3");

            entity.ToTable("historialmantenimientos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.MantenimientoId).HasColumnName("mantenimiento_id");
            entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");

            entity.HasOne(d => d.Mantenimiento).WithMany(p => p.Historialmantenimientos)
                .HasForeignKey(d => d.MantenimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__historial__mante__619B8048");

            entity.HasOne(d => d.Vehiculo).WithMany(p => p.Historialmantenimientos)
                .HasForeignKey(d => d.VehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__historial__vehic__60A75C0F");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__inventar__3213E83F005D3B90");

            entity.ToTable("inventario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cantidad");
            entity.Property(e => e.PiezaId).HasColumnName("pieza_id");

            entity.HasOne(d => d.Pieza).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.PiezaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__inventari__pieza__4F7CD00D");
        });

        modelBuilder.Entity<Mantenimiento>(entity =>
        {
            entity.HasKey(e => e.Idmantenimientos).HasName("PK__mantenim__8BFC265F2715BD11");

            entity.ToTable("mantenimientos");

            entity.Property(e => e.Idmantenimientos).HasColumnName("idmantenimientos");
            entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            entity.Property(e => e.TipoCambioId).HasColumnName("tipo_cambio_id");
            entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Mantenimientos)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mantenimi__prove__34C8D9D1");

            entity.HasOne(d => d.TipoCambio).WithMany(p => p.Mantenimientos)
                .HasForeignKey(d => d.TipoCambioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mantenimi__tipo___33D4B598");

            entity.HasOne(d => d.Vehiculo).WithMany(p => p.Mantenimientos)
                .HasForeignKey(d => d.VehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mantenimi__vehic__32E0915F");
        });

        modelBuilder.Entity<Perfil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__perfil__3213E83F2E4D7825");

            entity.ToTable("perfil");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Perfil1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perfil");
        });

        modelBuilder.Entity<Pieza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__piezas__3213E83F34A184BC");

            entity.ToTable("piezas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Piezas)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__piezas__proveedo__4BAC3F29");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Idproveedor).HasName("PK__proveedo__2DCD485D5982D9CE");

            entity.ToTable("proveedores");

            entity.Property(e => e.Idproveedor).HasColumnName("idproveedor");
            entity.Property(e => e.Contacto)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Reparacione>(entity =>
        {
            entity.HasKey(e => e.Idreparacion).HasName("PK__reparaci__DF7C26B8B0BCE881");

            entity.ToTable("reparaciones");

            entity.Property(e => e.Idreparacion).HasColumnName("idreparacion");
            entity.Property(e => e.Costo)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            entity.Property(e => e.TipoCambioId).HasColumnName("tipo_cambio_id");
            entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Reparaciones)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__reparacio__prove__3B75D760");

            entity.HasOne(d => d.TipoCambio).WithMany(p => p.Reparaciones)
                .HasForeignKey(d => d.TipoCambioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__reparacio__tipo___3A81B327");

            entity.HasOne(d => d.Vehiculo).WithMany(p => p.Reparaciones)
                .HasForeignKey(d => d.VehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__reparacio__vehic__398D8EEE");
        });

        modelBuilder.Entity<Tipocambio>(entity =>
        {
            entity.HasKey(e => e.Idtipocambio).HasName("PK__tipocamb__19E12018819EF1BE");

            entity.ToTable("tipocambios");

            entity.Property(e => e.Idtipocambio).HasColumnName("idtipocambio");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuario__3213E83F6719F250");

            entity.ToTable("usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(64)
                .HasColumnName("contrasena");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_completo");
            entity.Property(e => e.PerfilId).HasColumnName("perfil_id");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.Perfil).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.PerfilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuario__perfil___778AC167");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vehiculo__3213E83FBA668389");

            entity.ToTable("vehiculo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Kilometraje)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("kilometraje");
            entity.Property(e => e.Marca)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("placa");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
