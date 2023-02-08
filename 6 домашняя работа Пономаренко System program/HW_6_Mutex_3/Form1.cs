using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 3
//Создайте оконное приложение, которое может запускаться только в трёх копиях. При попытке запустить 
//четвертую копию необходимо отображать информационное сообщение и закрывать приложение

namespace HW_6_Mutex_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label1.Text = "Программа запущена!";
        }
    }
}
