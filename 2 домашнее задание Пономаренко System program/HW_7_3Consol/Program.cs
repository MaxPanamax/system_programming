using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Задание 3
//Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функции 
//Beep и MessageBeep из Windows API. С помощью импортированных функций сгенерируйте набор звуковых 
//сигналов через определенные промежутки времени.

namespace HW_7_3Consol
{
    public class DllImportExample
    {
        [DllImport("Kernel32.dll")]
        public static extern int Beep(uint dwFreq, uint dwDuration);
        [DllImport("User32.dll")]
        public static extern bool MessageBeep(uint type);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            if (DllImportExample.MessageBeep(0x40))
            {
                Console.WriteLine("(((((((((((((((Прибавь звук))))))))))))))))");
                Thread.Sleep(5000);
                DllImportExample.Beep(450, 2000);
                DllImportExample.Beep(500, 2000);
                DllImportExample.Beep(600, 2000);
                DllImportExample.Beep(700, 2000);
                DllImportExample.Beep(900, 2000);
                DllImportExample.Beep(1000, 2000);
                DllImportExample.Beep(1200, 2000);
                DllImportExample.Beep(1300, 2000);
                DllImportExample.Beep(1500, 2000);
            }
            DllImportExample.Beep(2000, 3000);
        }
    }
}
