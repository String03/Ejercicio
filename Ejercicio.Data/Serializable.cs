using Ejercicio.Contracts.Serializable;
using Ejercicio.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio.Data
{
    public class Serializable : ISerializable
    {
        public T Deserializable<T>(string xml)
        {
            Propiedades<T>();
            TextReader textReader = new StringReader(xml);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(textReader);
        }

        public string Serializar<T>(T entity)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream();
            xmlSerializer.Serialize(memoryStream, entity);
            return Encoding.ASCII.GetString(memoryStream.ToArray());
        }


        public void Propiedades<T>()
        {
            object instance = Activator.CreateInstance(typeof(T));
            var properties = instance.GetType().GetProperties();

            foreach (var prop in properties)
            {
                if (prop.GetCustomAttributes().Any(p => p.GetType() == typeof(NoFigureAttribute)))
                {
                    continue;
                }
            }
        }
    }
}
