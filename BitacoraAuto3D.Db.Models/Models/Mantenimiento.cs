﻿using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Mantenimiento
{
    public int Idmantenimientos { get; set; }

    public int VehiculoId { get; set; }

    public int TipoCambioId { get; set; }

    public int ProveedorId { get; set; }

    public virtual ICollection<Historialmantenimiento> Historialmantenimientos { get; set; } = new List<Historialmantenimiento>();

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual Tipocambio TipoCambio { get; set; } = null!;

    public virtual Vehiculo Vehiculo { get; set; } = null!;
}
