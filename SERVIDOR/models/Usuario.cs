using System;
using System.Collections.Generic;

namespace SERVIDOR.models;

public partial class Usuario
{
    public int Idusuario { get; set; }

    public string TipoUsuario { get; set; } = null!;

    public virtual ICollection<Dato> Datos { get; set; } = new List<Dato>();
}
