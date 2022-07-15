namespace Generics
{
    public class MenuInitialization
    {
        public static void InitializeMenu()
        {
            var menu = new MenuItem("Palavras");

            menu.Add(new MenuItem("Cadastrar Palavra", Dictionary.RegisterWord));
            menu.Add(new MenuItem("Buscar Palavra", Dictionary.SearchWord));
            menu.Add(new MenuItem("Listar Palavras", Dictionary.ListWords));
            menu.Add(new MenuItem("Editar Palavra", Dictionary.EditWord));
            menu.Add(new MenuItem("Remover Palavra", Dictionary.RemoveWord));
            menu.Add(new MenuItem("Sair", () => Environment.Exit(0)));

            menu.Execute();
        }
    }
}