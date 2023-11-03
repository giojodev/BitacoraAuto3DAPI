using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Comentario
{
    public int Id { get; set; }

    public int BitacoraId { get; set; }

    public int UsuarioId { get; set; }

    public string? Comentario1 { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Bitacoracambio Bitacora { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
