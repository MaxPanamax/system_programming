using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Задание 1
//Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функцию 
//MessageBox из Windows API. Отобразите с помощью 
//MessageBox информацию о вас. Данные должны быть 
//показаны в нескольких MessageBox.

namespace HW_task_1_Lis_7
{
    public class DllImportExample
    {
        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern int MessageBoxA(IntPtr hWnd, string text, string caption, uint type);
    }
    internal class Program
    {
        const string Infomation = "Сообщение";
        static void Main(string[] args)
        {
            DllImportExample.MessageBoxA(IntPtr.Zero, "Пономаренко Максим Борисович", Infomation, 0);
            DllImportExample.MessageBoxA(IntPtr.Zero, "Студент Академии \"TOP\"", Infomation, 0);
            Console.ReadKey();

        }
    }
}
