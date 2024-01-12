using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ByteDev.FileNamer.Ui.Controls
{
    public static class GenericExtensions
    {
        public static TSource CloneSerializable<TSource>(this TSource source)
        {
            if (!typeof(TSource).IsSerializable)
                throw new ArgumentException("The type must be serializable.");

            if (IsReferencingNull(source))
                return default(TSource);

            IFormatter formatter = new BinaryFormatter();

            using (Stream stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (TSource)formatter.Deserialize(stream);
            }
        }

        private static bool IsReferencingNull<TSource>(TSource source)
        {
            return ReferenceEquals(source, null);
        }
    }
}