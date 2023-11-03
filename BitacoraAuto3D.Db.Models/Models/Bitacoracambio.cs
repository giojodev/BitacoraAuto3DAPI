using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Bitacoracambio
{
    public int Id { get; set; }

    public int VehiculoId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<Foto> Fotos { get; set; } = new List<Foto>();

    public virtual Vehiculo Vehiculo { get; set; } = null!;
}
