using System;
using System.Collections.Generic;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class Historialmantenimiento
    {
        public int Id { get; set; }
        public int MantenimientoId { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
