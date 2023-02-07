using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Задание 2
//Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функции 
//FindWindow (поиск окна в системе), SendMessage(отсылка
//сообщений) из Windows API. Приложение должно произвести поиск окна вашего оконного приложения (можно 
//реализовать его с помощью Windows Forms и т.д.). Если
//окно найдено необходимо послать ему сообщение в зависимости от выбора пользователя:
//■ об изменении заголовка окна на заголовок, введенный 
//пользователем о закрытии окна;
//■ ваш вариант.

namespace HW_7_Task_2_Consol
{
    public class Max_test_sustem
    {
        [DllImport("User32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
    }

    internal class Program
    {
        const string app = "Max.Тестовое приложение";
        delegate void Handler(IntPtr child);
        static event Handler start;
        public static void TestApp(IntPtr child)
        {
            uint WM_SETTEXT = 0x000C;
            uint WM_SYSCOMMAND = 0x0112;
            uint SC_CLOSE = 0xF060;
            Console.WriteLine("Введите:\n1 - для закрытия окна дочернего приложения;\n2 - для изменения заголовка окна дочернего приложения;\n3 - для выхода.");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int chooseUser))
                {
                    if (chooseUser == 3)
                        break;
                    switch (chooseUser)
                    {
                        case 1:
                            Max_test_sustem.SendMessage(child, WM_SYSCOMMAND, SC_CLOSE, null);
                            break;
                        case 2:
                            Console.Write("Введите сообщение: ");
                            string mgs = Console.ReadLine();
                            Max_test_sustem.SendMessage(child, WM_SETTEXT, 0, mgs);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Не корректно набранная команда");
                }
            }
        }
        static void Main(string[] args)
        {

            try
            {
                start += TestApp;
                Console.Title = "Тест api-функциями FindWindow и SendMessage";
                Process p = Process.Start("HW_7_Task_2_WF.exe");
                Console.WriteLine("Для продолжения нажмите любую клавишу......");
                Console.ReadKey();
                IntPtr child = Max_test_sustem.FindWindow(null, app);
                if (child == IntPtr.Zero)
                {
                    Console.WriteLine("Тестовое приложение не найдено. Продолжение не возможно!");
                }
                else
                {
                    start?.Invoke(child);
                }
            }
            catch (Win32Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
