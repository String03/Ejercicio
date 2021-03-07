using Ejercicio.Data;
using Ejercicio.EE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.BLL
{
    public class PersonaBLL
    {
        private string _ruta;

        public PersonaBLL(string ruta)
        {
            _ruta = ruta;
        }

        public List<Persona> GetAll()
        {
            string xml = LeerXml();
            return Deserializar(xml).ListadePersonas;
        }

        private PersonaXML Deserializar(string xml)
        {

            try
            {
                Serializable serializable = new Serializable();
                return serializable.Deserializable<PersonaXML>(xml);
            }
            catch (Exception)
            {

                return new PersonaXML();    
            }
                     


        }

        private string LeerXml()
        {
            using (FileStream archivo = new FileStream(_ruta, FileMode.OpenOrCreate))
            {
                TextReader textreader = new StreamReader(archivo);
                return textreader.ReadToEnd();
            }
        }


        public void Save(Persona persona)
        {
            var listar = GetAll();
            listar.Add(persona);
            EscribirXML(listar);
        }

        private void EscribirXML(List<Persona> listar)
        {
            using (FileStream archivo = new FileStream(_ruta, FileMode.OpenOrCreate))
            {
                StreamWriter streamWriter = new StreamWriter(archivo);
                PersonaXML personaXML = new PersonaXML(listar);
                Serializable serializable = new Serializable();
                var s = serializable.Serializar(personaXML);
                streamWriter.WriteLine(s);
                streamWriter.Flush();
            }
        }
    }
}
