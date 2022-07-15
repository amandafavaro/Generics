namespace Generics
{
    public class WildcardsValidation
    {
        public static string ValidateWildcards(string word)
        {
            word = word.Replace("!", "");
            word = word.Replace("@", "");
            word = word.Replace("#", "");
            word = word.Replace("$", "");
            word = word.Replace("%", "");
            word = word.Replace("&", "");
            word = word.Replace("*", "");
            word = word.Replace("(", "");
            word = word.Replace(")", "");
            word = word.Replace("-", "");
            word = word.Replace("_", "");
            word = word.Replace("=", "");
            word = word.Replace("+", "");
            word = word.Replace("?", "");
            word = word.Replace("/", "");
            word = word.Replace("[", "");
            word = word.Replace("]", "");
            word = word.Replace("{", "");
            word = word.Replace("}", "");
            word = word.Replace("|", "");
            word = word.Replace(";", "");
            word = word.Replace(":", "");
            word = word.Replace(",", "");
            word = word.Replace(".", "");
            word = word.Replace("<", "");
            word = word.Replace(">", "");

            return word;
        }
    }
}
