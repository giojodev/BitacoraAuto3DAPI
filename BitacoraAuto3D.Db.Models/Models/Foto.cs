using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Foto
{
    public int Id { get; set; }

    public int BitacoraId { get; set; }

    public string Enlace { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Foto1 { get; set; } = null!;

    public virtual Bitacoracambio Bitacora { get; set; } = null!;
}
