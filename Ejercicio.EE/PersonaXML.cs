using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.EE
{
    public class PersonaXML
    {
        public List<Persona> ListadePersonas { get; set; } = new List<Persona>();

        public PersonaXML(List<Persona> listadePersonas)
        {
            ListadePersonas = listadePersonas;
        }

        public PersonaXML()
        {

        }
    }
}
