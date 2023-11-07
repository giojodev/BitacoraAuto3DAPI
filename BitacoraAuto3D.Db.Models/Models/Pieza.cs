using System;
using System.Collections.Generic;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class Pieza
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ProveedorId { get; set; }
        public decimal? Precio { get; set; }
    }
}
