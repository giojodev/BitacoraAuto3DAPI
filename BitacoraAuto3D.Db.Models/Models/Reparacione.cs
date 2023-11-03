using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Reparacione
{
    public int Idreparacion { get; set; }

    public int VehiculoId { get; set; }

    public int TipoCambioId { get; set; }

    public int ProveedorId { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Costo { get; set; }

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual Tipocambio TipoCambio { get; set; } = null!;

    public virtual Vehiculo Vehiculo { get; set; } = null!;
}
