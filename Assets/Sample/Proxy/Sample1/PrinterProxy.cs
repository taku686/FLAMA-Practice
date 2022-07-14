using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Proxy.Sample1
{
    public class PrinterProxy : IPrintable
    {
        private string _name;
        private Printer _real;

        public PrinterProxy(string name)
        {
            _name = name;
        }

        public void SetPrinterName(string name)
        {
            _real?.SetPrinterName(name);
            _name = name;
        }

        public string GetPrinterName()
        {
            return _name;
        }

        public void Print(string str)
        {
            Realize();
            _real.Print(str);
        }

        private void Realize()
        {
            _real ??= new Printer(_name);
        }
    }
}