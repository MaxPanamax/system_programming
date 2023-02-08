using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_6_Mutex_3
{
    internal static class Program
    {
        const int maxCountCopy = 3;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            /*Первый способ*/
            //using (var sem = new Semaphore(maxCountCopy, maxCountCopy, "Max"))
            //{
            //    if (sem.WaitOne(TimeSpan.FromSeconds(3)))
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(new Form1());
            //    }
            //    else
            //        MessageBox.Show("Это Semaphore", "Превышено максимально допустимое число копий приложения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            /*Второй способ*/
            if (Process.GetProcessesByName(Application.ProductName).Length > maxCountCopy)
            {
                MessageBox.Show("Это GetProcessesByName", "Превышено максимально допустимое число копий приложения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
