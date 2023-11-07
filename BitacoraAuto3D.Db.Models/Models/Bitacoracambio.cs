using System;
using System.Collections.Generic;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class Bitacoracambio
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
