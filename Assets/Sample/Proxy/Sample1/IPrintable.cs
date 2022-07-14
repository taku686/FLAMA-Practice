using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proxy.Sample1
{
    public interface IPrintable
    {
        void SetPrinterName(string name);
        string GetPrinterName();
        void Print(string str);
    }
}