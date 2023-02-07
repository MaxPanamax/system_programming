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

//Задание 3
//Разработайте приложение, которое умеет запускать 
//дочерний процесс и передавать ему аргументы командной 
//строки. В качестве аргументов должно быть два числа 
//и операция, которую необходимо выполнить. Например,
//аргументы:
//■ 7;
//■ 3;
//■ +.
//Дочерний процесс должен отобразить аргументы 
//и вывести результат сложения 10 на экран.

namespace HW_3_3_system_prog
{
    public partial class Form1 : Form
    {
        private ProcessStartInfo myProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            myProcess = new ProcessStartInfo("cmd.exe");
            myProcess.Arguments = $"/k echo {textBox1.Text} = &&" + $"set /a {textBox1.Text}";
            Process.Start(myProcess);
        }
    }
}
