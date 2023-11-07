using System;
using System.Collections.Generic;

#nullable disable

namespace BitacoraAuto3D.Db.Models.Models
{
    public partial class Comentario
    {
        public int Id { get; set; }
        public int BitacoraId { get; set; }
        public int UsuarioId { get; set; }
        public string Comentario1 { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
