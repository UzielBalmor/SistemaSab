using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Share
{
    public class DatoDTO
    {
        public int Iddatos { get; set; }
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string ApellidoPaterno { get; set; } = null!;
        [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio")]
        public string ApellidoMaterno { get; set; } = null!;
        [Required(ErrorMessage = "El campo Apellido Materno es obligatorio")]
        public string Curp { get; set; } = null!;
        [Required(ErrorMessage = "El campo Curp es obligatorio")]
        public string Correo { get; set; } = null!;
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public int Ni { get; set; }
        [Required(ErrorMessage = "El campo Numero Interior es obligatorio")]
        public int Ne { get; set; }
        [Required(ErrorMessage = "El campo Numero Exterior es obligatorio")]
        public string Calle { get; set; } = null!;
        [Required(ErrorMessage = "El campo Calle es obligatorio")]
        public string Localidad { get; set; } = null!;
        [Required(ErrorMessage = "El campo Localidad es obligatorio")]
        public string Municipio { get; set; } = null!;
        [Required(ErrorMessage = "El campo Municipio es obligatorio")]
        public string Estado { get; set; } = null!;
        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        public string Pais { get; set; } = null!;
        [Required(ErrorMessage = "El campo Pais es obligatorio")]
        public string Telefono { get; set; } = null!;
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string Contraseña { get; set; } = null!;
        [Required(ErrorMessage = "El campo Contraseña es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo usuario es obligatorio")]
        public int? Idusuario { get; set; }
        public UsuarioDTO? Usuario { get; set; }

    }
}
