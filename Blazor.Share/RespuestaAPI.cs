using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Share
{
    public class RespuestaAPI<T>
    {
        public bool RespuestaPeticion {  get; set; }
        public T? Valor { get; set; }

        public string? Mensaje { get; set; }

    }
}
