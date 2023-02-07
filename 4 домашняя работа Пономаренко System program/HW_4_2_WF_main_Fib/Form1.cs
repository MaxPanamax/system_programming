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

//Задание 2
//Добавьте к первому заданию поток, генерирующий 
//набор чисел Фибоначчи. Числа должны отображаться 
//в оконном интерфейсе.
namespace HW_4_1_WF_main
{
    public partial class Form1 : Form
    {
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
                result.Append(string.Format("{0} {1} ", i, j));
                i += j;
            }

            if (i <= max)
                result.Append(i);

            return result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart threadstart = new ThreadStart(Process_main);
            Thread thread = new Thread(threadstart);
            thread.Start();
            textBox4.AppendText(Fibonacci(Convert.ToInt32(textBox2.Text)).ToString());
            textBox4.AppendText("Последовательность Фибоначи до числа: " + textBox2.Text);
        }
    }
}
