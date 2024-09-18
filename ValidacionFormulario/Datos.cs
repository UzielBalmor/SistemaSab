using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionFormulario
{
    public class DATOS
    {
        public int IdDatos { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Ape { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

    }
}
