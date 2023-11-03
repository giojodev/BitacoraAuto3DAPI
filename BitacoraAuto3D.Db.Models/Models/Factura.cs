using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Factura
{
    public int Idfactura { get; set; }

    public int ClienteId { get; set; }

    public int VehiculoId { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Monto { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Vehiculo Vehiculo { get; set; } = null!;
}
