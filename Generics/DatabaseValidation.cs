namespace Generics
{
    public class DatabaseValidation : Database
    {
        public static void ValidateDatabase()
        {
            if (!File.Exists(wordsDb))
            {
                Dictionary.Add(new Dictionary { Palavra = "Default", Significado = "Padrão" });
                Save.SaveDictionary();
            }
        }
    }
}
