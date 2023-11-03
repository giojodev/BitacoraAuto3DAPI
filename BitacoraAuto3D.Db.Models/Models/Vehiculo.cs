using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Vehiculo
{
    public int Id { get; set; }

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int Anio { get; set; }

    public string Placa { get; set; } = null!;

    public decimal Kilometraje { get; set; }

    public virtual ICollection<Bitacoracambio> Bitacoracambios { get; set; } = new List<Bitacoracambio>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Fotosmodelo3D> Fotosmodelo3Ds { get; set; } = new List<Fotosmodelo3D>();

    public virtual ICollection<Historialmantenimiento> Historialmantenimientos { get; set; } = new List<Historialmantenimiento>();

    public virtual ICollection<Mantenimiento> Mantenimientos { get; set; } = new List<Mantenimiento>();

    public virtual ICollection<Reparacione> Reparaciones { get; set; } = new List<Reparacione>();
}
