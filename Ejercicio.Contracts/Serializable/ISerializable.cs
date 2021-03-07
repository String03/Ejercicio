using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Contracts.Serializable
{
    public interface ISerializable
    {
        string Serializar<T>(T entity);

        T Deserializable<T>(string xml);
    }
}
