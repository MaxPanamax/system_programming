using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 2
//Разработайте приложение, которое умеет запускать 
//дочерний процесс. В зависимости от выбора пользователя 
//родительское приложение должно ожидать завершения 
//дочернего процесса и отображать код завершения либо 
//принудительно завершать работу дочернего процесса.

namespace HW_3_2_system_prog
{
    public partial class Form1 : Form
    {
        private Process MyProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyProcess = new Process();
                MyProcess.StartInfo.FileName = "notepad.exe";
                MyProcess.Start();
                if (checkBox1.Checked)
                {
                    MyProcess.WaitForExit();
                    if (MyProcess.HasExited)
                    {
                        MessageBox.Show($"Процесс завершен. Код завершения:" +
                            $" {MyProcess.ExitCode}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MyProcess?.CloseMainWindow();
                MyProcess?.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
