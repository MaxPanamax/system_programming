using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 1
//Создайте приложение, использующее механизм событий. Создайте в коде приложения несколько потоков. 
//Первый поток генерирует и сохраняет в файл некоторое 
//количество пар чисел. Второй поток ожидает завершения генерации, после чего подсчитывает сумму каждой 
//пары. Результат записывается в файл. Третий поток тоже 
//ожидает завершения генерации, после чего подсчитывает 
//произведение каждой пары. Результат записывается в файл.

namespace HW_7_Module_4_Synchronization_WF
{
    public partial class Form1 : Form
    {
        private string[] nameThread = { "Процесс заполнения файла парами чисел", 
            "Процесс суммирование пар чисел", "Процесс произведение пар чисел" };
        public Form1()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;
            buttonReportShow.Click += ButtonReportShow_Click;
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            Worker worker = new Worker();
            worker.WorkBegin += Worker_WorkBegin;
            worker.WorkEnd += Worker_WorkEnd;
            Thread[] threads = new Thread[nameThread.Length];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(worker.Start);
                threads[i].Name = nameThread[i];
                threads[i].Start(i);
            }
        }
        private void Worker_WorkBegin(string info)
        {
            Action action = () => { listBoxLog.Items.Add(info); };
            this.InvokeEx(action);
        }
        private void Worker_WorkEnd(string info)
        {
            Action action = () => { listBoxLog.Items.Add(info); };
            this.InvokeEx(action);
        }

        private void ButtonReportShow_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewReport.DataSource = null;
                buttonStart.Enabled = true;
                var sql = (from info in Worker.ShowStatistic()
                           select new
                           {
                               Количество_чисел = info.countNumber,
                               Размер_файла = info.sizeFile,
                               Контент = info.fileСontent.Substring(0, 1000)
                           }).ToList();
                dataGridViewReport.DataSource = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
