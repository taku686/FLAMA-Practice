using System;
using UnityEngine;

namespace Sample.Command.Sample3
{
    public class CommandSample3 : MonoBehaviour
    {
        private void Start()
        {
            var download = new Downloader();

            var videoDownloader = new VideoDownloadCommand(download, "video.vid");
            var imageDownloader = new ImageDownloadCommand(download, "image.png");

            videoDownloader.Execute();
            imageDownloader.Execute();
        }
    }
}