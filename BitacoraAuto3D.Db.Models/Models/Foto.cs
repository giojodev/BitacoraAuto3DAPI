using System;
using System.Collections.Generic;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class Foto
    {
        public int Id { get; set; }
        public int BitacoraId { get; set; }
        public string Enlace { get; set; }
        public string Descripcion { get; set; }
        public string Foto1 { get; set; }
    }
}
