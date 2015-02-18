using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace RawPrinterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1){
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new PrinterSettings();
                if (DialogResult.OK == pd.ShowDialog()){
                    if (File.Exists(args[0])){
                        RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, args[0]);
                    }
                }
            }
        }
    }
}
