using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class BITACORA3DContext : DbContext
    {
        public BITACORA3DContext()
        {
        }

        public BITACORA3DContext(DbContextOptions<BITACORA3DContext> options)
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3SEDC9P;Database=BITACORA3D;User=adminbitacora;Password=bitacora**123;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Bitacoracambio>(entity =>
            {
                entity.ToTable("bitacoracambios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__clientes__885457EE0876739B");

                entity.ToTable("clientes");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.ToTable("comentarios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BitacoraId).HasColumnName("bitacora_id");

                entity.Property(e => e.Comentario1)
                    .IsUnicode(false)
                    .HasColumnName("comentario");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.Idfactura)
                    .HasName("PK__facturas__40FF55D8B889AD80");

                entity.ToTable("facturas");

                entity.Property(e => e.Idfactura).HasColumnName("idfactura");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");
            });

            modelBuilder.Entity<Foto>(entity =>
            {
                entity.ToTable("fotos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BitacoraId).HasColumnName("bitacora_id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Enlace)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("enlace");

                entity.Property(e => e.Foto1)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("foto");
            });

            modelBuilder.Entity<Fotosmodelo3D>(entity =>
            {
                entity.ToTable("fotosmodelo3D");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enlace)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("enlace");

                entity.Property(e => e.FechaSubida)
                    .HasColumnType("date")
                    .HasColumnName("fecha_subida")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");
            });

            modelBuilder.Entity<Historialmantenimiento>(entity =>
            {
                entity.ToTable("historialmantenimientos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MantenimientoId).HasColumnName("mantenimiento_id");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.ToTable("inventario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PiezaId).HasColumnName("pieza_id");
            });

            modelBuilder.Entity<Mantenimiento>(entity =>
            {
                entity.HasKey(e => e.Idmantenimientos)
                    .HasName("PK__mantenim__8BFC265F8BD2EEF4");

                entity.ToTable("mantenimientos");

                entity.Property(e => e.Idmantenimientos).HasColumnName("idmantenimientos");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.TipoCambioId).HasColumnName("tipo_cambio_id");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.ToTable("perfil");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Perfil1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("perfil");
            });

            modelBuilder.Entity<Pieza>(entity =>
            {
                entity.ToTable("piezas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.Idproveedor)
                    .HasName("PK__proveedo__2DCD485D717872A2");

                entity.ToTable("proveedores");

                entity.Property(e => e.Idproveedor).HasColumnName("idproveedor");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("contacto");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Reparacione>(entity =>
            {
                entity.HasKey(e => e.Idreparacion)
                    .HasName("PK__reparaci__DF7C26B8ADF42E3C");

                entity.ToTable("reparaciones");

                entity.Property(e => e.Idreparacion).HasColumnName("idreparacion");

                entity.Property(e => e.Costo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("costo")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.TipoCambioId).HasColumnName("tipo_cambio_id");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");
            });

            modelBuilder.Entity<Tipocambio>(entity =>
            {
                entity.HasKey(e => e.Idtipocambio)
                    .HasName("PK__tipocamb__19E1201842A4F1A6");

                entity.ToTable("tipocambios");

                entity.Property(e => e.Idtipocambio).HasColumnName("idtipocambio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("contrasena");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.Usuario1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.ToTable("vehiculo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Kilometraje)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("kilometraje");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("modelo");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("placa");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
