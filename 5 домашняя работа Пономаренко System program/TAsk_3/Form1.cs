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

namespace TAsk_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string Fibonacci(int min,int max)
        {
            int i = 0;
            StringBuilder result = new StringBuilder();

            for (int j = min; j <= max; j += i)
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
            textBox3.AppendText(Fibonacci(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text)).ToString());
            textBox3.AppendText("Последовательность Фибоначчи до числа: " + textBox2.Text);
        }
    }
}
