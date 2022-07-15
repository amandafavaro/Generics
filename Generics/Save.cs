using System.Xml.Serialization;

namespace Generics
{
    public class Save : Database
    {
        public static void SaveDictionary()
        {
            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(List<Dictionary>));
            using (TextWriter writer = new StreamWriter(wordsDb))
            {
                dictionarySerializer.Serialize(writer, Dictionary);
            }
        }
    }
}
