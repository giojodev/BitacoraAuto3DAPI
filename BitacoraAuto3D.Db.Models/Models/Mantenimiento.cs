using System;
using System.Collections.Generic;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class Mantenimiento
    {
        public int Idmantenimientos { get; set; }
        public int VehiculoId { get; set; }
        public int TipoCambioId { get; set; }
        public int ProveedorId { get; set; }
    }
}
