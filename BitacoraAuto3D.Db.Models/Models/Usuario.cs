using System;
using System.Collections.Generic;

namespace BitacoraAuto3D.Db.Models.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Usuario1 { get; set; } = null!;

    public byte[] Contrasena { get; set; } = null!;

    public string NombreCompleto { get; set; } = null!;

    public int PerfilId { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual Perfil Perfil { get; set; } = null!;
}
