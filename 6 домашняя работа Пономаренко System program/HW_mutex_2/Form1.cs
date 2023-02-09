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

namespace CW_mutex_2
{
    public partial class Form1 : Form
    {
        Mutex mutex = new Mutex();
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(Thread1Numbers);
            thread1.Name = "Поток 1";
            Thread thread2 = new Thread(Thread2Numbers);
            thread2.Name = "Поток 2";
            thread1.Start();
            thread2.Start();
        }
        private void Thread1Numbers()
        {
            mutex.WaitOne();
            for (int i = 0; i <= 20; i++)
            {
                Thread.Sleep(100);
                Invoke(new Action<string>((threanName) =>
                {
                    label1.Text = threanName + " начал свою работу";
                    listBox1.Items.Add(i);
                }), Thread.CurrentThread.Name);
            }
            mutex.ReleaseMutex();
        }

        private void Thread2Numbers()
        {
            mutex.WaitOne();
            for (int i = 20; i >= 0; i--)
            {
                Thread.Sleep(100);
                Invoke(new Action<string>((threanName) =>
                {
                    label1.Text = "\n" + threanName + " начал свою работу";
                    listBox2.Items.Add(i);
                }), Thread.CurrentThread.Name);
            }
            mutex.ReleaseMutex();
        }
    }
}
