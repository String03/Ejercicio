using Ejercicio.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.EE
{
    public class Persona
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        [NoFigure]
        public DateTime Fecha_reg { get; set; }

    }
}
