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

//Задание 1
//Разработайте приложение, которое умеет запускать 
//дочерний процесс и ожидать его завершения. Когда дочерний процесс завершен, родительское приложение 
//должно отобразить код завершения.

namespace HW_3_1_system_prog
{
    public partial class Form1 : Form
    {
        private Process myProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess = new Process();
                myProcess.StartInfo.FileName = "notepad.exe";
                myProcess.EnableRaisingEvents= true;
                myProcess.Exited += MyProcess_Exited;
                myProcess.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyProcess_Exited(object sender, EventArgs e)
        {
            MessageBox.Show($"Время выхода: {myProcess.ExitTime}\nКод выхода: " +
                $"{myProcess.ExitCode}", "Инфорация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            myProcess.Close();
        }
    }
}
