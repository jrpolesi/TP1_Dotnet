namespace exercicio11;

class Program
{
    static void Main(string[] args)
    {
        Func<string, string, string>? processName = ConcatFullName;
        processName += (string firstName, string lastName) => ToUpper(ConcatFullName(firstName, lastName));
        processName += (string firstName, string lastName) => RemoveSpaces(ConcatFullName(firstName, lastName));

        var name = "João";
        var lastName = "Silva";

        var result = processName?.Invoke(name, lastName);

        // Após analisar o retorno é possível verificar que por mais que todos os métodos 
        // foram executado, porém o resultado corresponde apenas ao último método.
        Console.WriteLine(result); // JoãoSilva
    }

    private static string ConcatFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }

    private static string ToUpper(string str)
    {
        return str.ToUpper();
    }

    private static string RemoveSpaces(string str)
    {
        return str.Replace(" ", "");
    }
}