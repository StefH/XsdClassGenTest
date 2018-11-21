using System;
using System.IO;
using System.Xml.Serialization;

namespace Common
{
    public static class XmlConverter
    {
        /// <summary>
        /// Deserializes the JSON to the specified .NET type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The XML to deserialize.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
		public static T DeserializeObject<T>(string value) where T : class
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Cannot deserialize from a null or empty string.", nameof(value));
            }

            var serializer = new XmlSerializer(typeof(T));

            using (var stream = new StringReader(value))
            {
                return serializer.Deserialize(stream) as T;
            }
        }

        /// <summary>
        /// Serializes the specified object to a XML string.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <returns>A XML string representation of the object.</returns>
        public static string SerializeObject(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Cannot serialize from a null object.");
            }

            var serializer = new XmlSerializer(value.GetType());
            using (var stream = new StringWriter())
            {
                serializer.Serialize(stream, value);
                return stream.ToString();
            }
        }
    }
}
