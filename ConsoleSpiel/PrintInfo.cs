using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSpiel
{
    public class PrintInfo
    {
        public string TextToPrint { get; set; }
        public ConsoleColor TextColor { get; set; }
        public bool PrintLine { get; set; }
        public PrintInfo(string textToPrint, ConsoleColor textColor, bool printLine)
        {
            TextToPrint = textToPrint;
            TextColor = textColor;
            PrintLine = printLine;
        }
    }
}
