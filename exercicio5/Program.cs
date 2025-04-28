namespace exercicio5;

class Program
{
    static void Main(string[] args)
    {
        var downloadManager = new DownloadManager();
        downloadManager.DownloadCompleted += OnDownloadCompleted;

        downloadManager.StartDownload();
    }

    private static void OnDownloadCompleted(object? sender, EventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("O download foi concluído com sucesso!");
        Console.ResetColor();

        Environment.Exit(0);
    }
}