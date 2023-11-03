using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Historialmantenimiento
{
    public int Id { get; set; }

    public int VehiculoId { get; set; }

    public int MantenimientoId { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Mantenimiento Mantenimiento { get; set; } = null!;

    public virtual Vehiculo Vehiculo { get; set; } = null!;
}
