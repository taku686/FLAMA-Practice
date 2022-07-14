using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Proxy.Sample1
{
    public class Printer : IPrintable
    {
        private string _name;

        public Printer()
        {
            HeavyJob("Printerのインスタンスを生成中");
        }

        public Printer(string name)
        {
            _name = name;
            HeavyJob($"Printerのインスタンス({_name})を生成中");
        }

        public void SetPrinterName(string name)
        {
            _name = name;
        }

        public string GetPrinterName()
        {
            return _name;
        }

        public void Print(string str)
        {
            Debug.Log($"===={_name}====");
            Debug.Log(str);
        }

        private void HeavyJob(string msg)
        {
            Debug.Log(msg);

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Thread.Sleep(1000);
                }
                catch (ThreadInterruptedException ex)
                {
                    Debug.Log(ex.Message);
                }

                Debug.Log(".");
            }

            Debug.Log("完了しました");
        }
    }
}