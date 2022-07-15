namespace Generics
{
    public class Database
    {
        protected static readonly string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
        protected static readonly string wordsDb = Path.Combine(rootDirectory, "dictionary.xml");

        public static List<Dictionary> Dictionary = new List<Dictionary>();

        static Database()
        {
            DatabaseValidation.ValidateDatabase();
            Load.LoadDictionary();
        }

        public static void AddWord(Dictionary word)
        {
            Dictionary.Add(word);
        }

        public static void RemoveWord(Dictionary word)
        {
            Dictionary.Remove(word);
        }
    }
}
