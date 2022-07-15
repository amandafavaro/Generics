namespace Generics
{
    public class ConsoleInput
    {
        public static string GetString(string prompt, string suggestion = "")
        {
            if (!string.IsNullOrEmpty(suggestion))
                suggestion = $" ({suggestion})";

            Console.Write($"{prompt}{suggestion} ");
            var input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input) && !string.IsNullOrWhiteSpace(suggestion))
                input = suggestion;

            return input;
        }
    }
}
