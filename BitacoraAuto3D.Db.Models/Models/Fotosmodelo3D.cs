using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Fotosmodelo3D
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Enlace { get; set; } = null!;

    public DateTime? FechaSubida { get; set; }

    public int VehiculoId { get; set; }

    public virtual Vehiculo Vehiculo { get; set; } = null!;
}
