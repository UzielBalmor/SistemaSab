using System;
using System.Collections.Generic;

namespace SERVIDOR.models;

public partial class Dato
{
    public int Iddatos { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string ApellidoMaterno { get; set; } = null!;

    public string Curp { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int Ni { get; set; }

    public int Ne { get; set; }

    public string Calle { get; set; } = null!;

    public string Localidad { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public int? Idusuario { get; set; }

    public virtual Usuario? IdusuarioNavigation { get; set; }
}
