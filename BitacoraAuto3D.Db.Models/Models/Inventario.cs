using System;
using System.Collections.Generic;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class Inventario
    {
        public int Id { get; set; }
        public int PiezaId { get; set; }
        public int? Cantidad { get; set; }
    }
}
