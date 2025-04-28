namespace exercicio7;

class Program
{
    static void Main(string[] args)
    {
        Action<string>? multicastLog = null;

        // multicastLog += Logger.LogToConsole;
        // multicastLog += Logger.LogToFile;
        // multicastLog += Logger.LogToDatabase;

        multicastLog?.Invoke("Esta é uma mensagem de log.");
    }
}