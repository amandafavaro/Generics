using System.Xml.Serialization;

namespace Generics
{
    public class Load : Database
    {
        public static void LoadDictionary()
        {
            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(List<Dictionary>));
            using (TextReader reader = new StreamReader(Database.wordsDb))
            {
                var words = dictionarySerializer.Deserialize(reader) as List<Dictionary>;
                Dictionary = words ?? new List<Dictionary>();
            }
        }
    }
}
