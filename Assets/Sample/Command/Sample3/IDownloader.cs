using UnityEngine;

namespace Sample.Command.Sample3
{
    public interface IDownloader
    {
        // Download video
        void DownloadVideo(string url);

        // Download image
        void DownloadImage(string url);
    }
}