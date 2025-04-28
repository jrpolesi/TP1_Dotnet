namespace exercicio2;

public class Welcome
{
    public static void InPortuguese(string name)
    {
        Console.WriteLine($"Olá, {name}!");
        Console.WriteLine("Seja bem vindo(a).");
    }

    public static void InEnglish(string name)
    {
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine("Welcome.");
    }

    public static void InSpanish(string name)
    {
        Console.WriteLine($"Hola, {name}!");
        Console.WriteLine("Bienvenido(a).");
    }
}