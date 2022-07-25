using UnityEngine;

namespace Sample.Command.Sample3
{
    public class Downloader : IDownloader
    {
        public void DownloadVideo(string url)
        {
            Debug.Log("Video Download!!");
        }

        public void DownloadImage(string url)
        {
            Debug.Log("Image Download!!");
        }
    }
}