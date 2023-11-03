using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Proveedore
{
    public int Idproveedor { get; set; }

    public string Nombre { get; set; } = null!;

    public string Contacto { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public virtual ICollection<Mantenimiento> Mantenimientos { get; set; } = new List<Mantenimiento>();

    public virtual ICollection<Pieza> Piezas { get; set; } = new List<Pieza>();

    public virtual ICollection<Reparacione> Reparaciones { get; set; } = new List<Reparacione>();
}
