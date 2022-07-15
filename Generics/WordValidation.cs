namespace Generics
{
    public class WordValidation
    {
        public static int ValidateWord(string search)
        {
            if (search.Contains(" "))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A busca aceita apenas palavras inteiras ou parte de palavras.");
                return 1;
            }
            return 0;
        }
    }
}
