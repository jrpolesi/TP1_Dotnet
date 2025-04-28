namespace exercicio2;

class Program
{
    static void Main(string[] args)
    {
        var name = InputTypeString("Digite seu nome: ");
        var language = InputLanguage("Escolha o idioma: ");

        Action<string> welcomeMessage = language switch
        {
            1 => Welcome.InPortuguese,
            2 => Welcome.InEnglish,
            3 => Welcome.InSpanish,
            _ => throw new Exception("Invalid option")
        };

        welcomeMessage(name);
    }

    private static int InputLanguage(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("1 - Português");
        Console.WriteLine("2 - Inglês");
        Console.WriteLine("3 - Espanhol");

        if (int.TryParse(Console.ReadLine(), out int value) && (value > 0 && value < 4))
        {
            return value;
        }

        Console.WriteLine("Valor inválido, tente novamente.");
        return InputLanguage(message);
    }

    private static string InputTypeString(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "";
    }
}