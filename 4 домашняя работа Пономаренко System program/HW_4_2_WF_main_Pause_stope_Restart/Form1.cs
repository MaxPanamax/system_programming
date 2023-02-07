using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 4
//Добавьте к третьему заданию кнопки для приостановления и возобновления каждого из потоков. Например,
//пользователь может приостановить генерацию чисел Фибоначчи по нажатию на кнопку. Продолжение генерации 
//возможно по нажатию на другую кнопку
namespace HW_4_1_WF_main
{
    public partial class Form1 : Form
    {
        ThreadStart threadstart;
        Thread thread;
        ThreadStart threadStart;
        Thread thread1;
        public Form1()
        {
            InitializeComponent();
         
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //Чтобы программно проверить простое число или нет
        //достаточно проверить не делится ли это число на числа
        //до квадратного корня из этого числа. Если делится - число не простое,
        //в противном случае - простое.
        private static bool IsPrimeNumber(int number)
        {
            int sqrtNumber = (int)(Math.Sqrt(number));
            for (int i = 2; i <= sqrtNumber; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        private void Process_main()
        {
            int count = 0;
            int minNumber = Convert.ToInt32(textBox1.Text);
            int maxNumber = Convert.ToInt32(textBox2.Text);// максимальное число, до которого будем считать (можно менять)
                                                           // можно переделать на ввод с клавиатуры
            if (minNumber == maxNumber)
            { MessageBox.Show(" Неправильные значения");textBox1.Text = null;textBox2.Text = null; }
            if (minNumber < 2)
            {
                minNumber = 2;
                textBox3.Text = null;
                 for (int num = minNumber; num <= maxNumber; num++)
                 {
                     if (IsPrimeNumber(num))
                     {
                        Thread.Sleep(100);
                        count++;
                         textBox3.AppendText(num.ToString() + ","); 
                     }
                 }
                textBox3.AppendText("всего простых чисел в заданном диопазоне: " + count);
            }
            else
            {
                textBox3.Text = null;
                for (int num = minNumber; num <= maxNumber; num++)
                {
                    if (IsPrimeNumber(num))
                    {
                        Thread.Sleep(100);
                        count++;
                        textBox3.AppendText(num.ToString() + ","); 
                    }
                }
                textBox3.AppendText("всего простых чисел в заданном диопазоне: " + count);
            }
        }
        private string Fibonacci(int max)
        {
            int i = 0;
            StringBuilder result = new StringBuilder();

            for (int j = 1; j <= max; j += i)
            {
                Thread.Sleep(100);
                result.Append(string.Format("{0} {1} ", i, j));
                i += j;
            }

            if (i <= max)
                result.Append(i);

            return result.ToString();
        }
        private void AppendText_Fibonacci()
        {
            textBox4.AppendText(Fibonacci(Convert.ToInt32(textBox2.Text)).ToString());
            textBox4.AppendText("Последовательность Фибоначи до числа: " + textBox2.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            threadstart = new ThreadStart(Process_main);
            thread = new Thread(threadstart);
            thread.Start();
            threadStart = new ThreadStart(AppendText_Fibonacci);
            thread1 = new Thread(threadStart);
            thread1.Start(); 

        }
        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            thread1.Suspend(); MessageBox.Show("Процесс Фибоначчи преостановлен");
        }

        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
           thread.Suspend(); MessageBox.Show("Процесс простых чисел приостановлен");
        }
        [Obsolete]
        private void button7_Click(object sender, EventArgs e)
        {
            thread1.Resume(); MessageBox.Show("Процесс Фибоначчи возобнавлён");
        }
        [Obsolete]
        private void button6_Click(object sender, EventArgs e)
        {
            thread.Resume();MessageBox.Show("Процесс простых чисел возобнавлён");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (thread?.ThreadState == ThreadState.WaitSleepJoin)
               thread?.Abort(); 
            MessageBox.Show("Процесс простых чисел завершен");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (thread1?.ThreadState == ThreadState.WaitSleepJoin)
                thread1.Abort(); MessageBox.Show("Процесс Фибоначчи завершен");
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (thread?.ThreadState == ThreadState.WaitSleepJoin|| thread1?.ThreadState == ThreadState.WaitSleepJoin)
                thread?.Abort();thread1?.Abort();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            MessageBox.Show("Введите новые границы и нажмите СТАРТ");
        }
    }
}
