using UnityEngine;

namespace Sample.Command.Sample3
{
    public class ImageDownloadCommand : ICommand
    {
        private readonly Downloader _downloader;
        private readonly string _url;

        public ImageDownloadCommand(Downloader downloader, string url)
        {
            _downloader = downloader;
            _url = url;
        }

        public void Execute()
        {
            Debug.Log("コマンド発令");
            _downloader.DownloadImage(_url);
        }
    }
}