using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace AssetBundle.Sample1
{
    public class AssetBundleSample1 
    {
        private void CreateAssetBundle()
        {
            /*List<AssetBundleBuild> builds = new List<AssetBundleBuild>();
            var build = new AssetBundleBuild();
            build.assetBundleName = "test1/DesignPatternList";
            build.assetNames = new string[1] { "Assets/Sample/AssetBundle/Sample1/test1/DesignPatternList.png" };
            builds.Add(build);

            var targetDir = "AssetBundle/Android";
            if (!Directory.Exists(targetDir)) Directory.CreateDirectory(targetDir);
            var buildTarget = BuildTarget.Android;
            var buildOptions = BuildAssetBundleOptions.ChunkBasedCompression;

            BuildPipeline.BuildAssetBundles(targetDir, builds.ToArray(), buildOptions, buildTarget);*/
        }
    }
}