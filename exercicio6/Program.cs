namespace exercicio6;

class Program
{
    static void Main(string[] args)
    {
        Action<string> multicastDelegate = Logger.LogToConsole;
        multicastDelegate += Logger.LogToFile;
        multicastDelegate += Logger.LogToDatabase;

        multicastDelegate("Esta é uma mensagem de log.");
    }
}