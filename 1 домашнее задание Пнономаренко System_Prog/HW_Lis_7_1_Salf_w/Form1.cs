using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

//Создание простейшего приложения,
//"порождающего" процесс

namespace HW_Lis_7_1_Salf_w
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myProcess.StartInfo=new ProcessStartInfo("calc.exe");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myProcess.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //myProcess.OnExited();недоступен из-за уровня защиты
            myProcess.CloseMainWindow();//с ошибкой из-за уровня прав
            myProcess.Close();
        }
    }
}
