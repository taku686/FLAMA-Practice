using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proxy.Sample1
{
    public class Program : MonoBehaviour
    {
        private void Start()
        {
            IPrintable iPrintable = new PrinterProxy("佐藤");
            Debug.Log($"名前は現在{iPrintable.GetPrinterName()}です。");
            iPrintable.SetPrinterName("田中");
            Debug.Log($"名前は現在{iPrintable.GetPrinterName()}です。");
            iPrintable.Print("Hello World!");
        }
    }
}