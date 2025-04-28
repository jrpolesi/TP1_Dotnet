namespace exercicio5;

public class DownloadManager
{
    public event EventHandler? DownloadCompleted;

    private int _downloadProgress;

    public void StartDownload()
    {
        Console.WriteLine($"Iniciando o download...");

        while (_downloadProgress < 100)
        {
            _downloadProgress += 10;
            Console.WriteLine($"Progresso do download: {_downloadProgress}%");
            Thread.Sleep(200);
        }

        Console.WriteLine($"Download completo!");

        OnDownloadCompleted();
    }

    protected virtual void OnDownloadCompleted()
    {
        DownloadCompleted?.Invoke(this, EventArgs.Empty);
    }
}