using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources06
{
    enum PrinterColors
    {
        Red=0,
        Green=1,
        Blue=2
    }
    static class Printer
    {
        static public void Print(string str, int color)
        {
            ConsoleColor backupedColor = Console.ForegroundColor;

            Console.ForegroundColor = GetConsoleColor(color);
            Console.WriteLine(str);

            Console.ForegroundColor = backupedColor;
        }

        static private ConsoleColor GetConsoleColor(int color)
        {
            ConsoleColor result;
            

            switch ((PrinterColors)color)
            {
                case PrinterColors.Red:
                    result = ConsoleColor.Red;
                    break;
                case PrinterColors.Green:
                    result = ConsoleColor.Green;
                    break;
                case PrinterColors.Blue:
                    result = ConsoleColor.Blue;
                    break;
                default:
                    throw new Exception("Неизвестная ошибка");
                    break;
            }
            return result;
        }
    }
        
    
}
