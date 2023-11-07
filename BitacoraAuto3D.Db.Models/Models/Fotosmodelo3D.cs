using System;
using System.Collections.Generic;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class Fotosmodelo3D
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Enlace { get; set; }
        public DateTime? FechaSubida { get; set; }
        public int VehiculoId { get; set; }
    }
}
