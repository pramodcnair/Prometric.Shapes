using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Prometric.Shape
{
    class XMLSerializerStrategy : ISerializeStrategy
    {
        public string SerializeObject<T>(T obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, obj);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
    }
}
