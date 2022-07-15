using BetterConsoleTables;
using Sharprompt;
using System.ComponentModel.DataAnnotations;

namespace Generics
{
    public class Dictionary
    {
        [Display(Name = "Palavra")]
        [Required(ErrorMessage = "A palavra é obrigatória!")]
        public string Palavra { get; set; }

        [Display(Name = "Significado")]
        [Required(ErrorMessage = "O significado é obrigatório!")]
        public string Significado { get; set; }        

        public static void RegisterWord()
        {
            var word = Prompt.Bind<Dictionary>();

            word.Palavra = WildcardsValidation.ValidateWildcards(word.Palavra);
            word.Significado = WildcardsValidation.ValidateWildcards(word.Significado);

            if (!Prompt.Confirm("Deseja salvar"))
                return;

            Database.AddWord(word);
            Save.SaveDictionary();
        }

        public static void SearchWord()
        {
            var search = Prompt.Input<string>("Qual palavra você deseja buscar");

            search = WildcardsValidation.ValidateWildcards(search);

            var count = WordValidation.ValidateWord(search);

            foreach (var word in Database.Dictionary)
            {
                if (word.Palavra.Contains(search, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{word.Palavra} - {word.Significado}");
                    count++;
                }
            }

            if (count < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhuma palavra encontrada!");
            }
        }

        public static void ListWords()
        {
            var table = new Table(TableConfiguration.Unicode());
            table.From(Database.Dictionary);
            Console.WriteLine(table.ToString());
        }

        public static void EditWord()
        {
            var word = Prompt.Select("Seleciona a palavra para editar", Database.Dictionary, defaultValue: Database.Dictionary[0]);

            Prompt.Bind(word);

            Save.SaveDictionary();
        }

        public static void RemoveWord()
        {
            var word = Prompt.Select("Selecione a palavra para remover", Database.Dictionary);
            var confirm = Prompt.Confirm("Tem certeza", false);

            if (!confirm)
                return;

            Database.RemoveWord(word);
            Save.SaveDictionary();
        }

        public override string ToString()
        {
            return Palavra;
        }
    }
}
