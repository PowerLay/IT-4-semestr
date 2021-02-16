using System;
using System.Windows.Forms;

namespace Практика_4_Индивидуальное_задание_12_Вариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToDouble(textBox1.Text.Replace('.',','));
            var eps = Convert.ToDouble(textBox1.Text.Replace('.', ','));
            textBox2.Text = "Результаты работы программы ст. Иванова И.И. " + Environment.NewLine;
            var m = 0;
            if (radioButton2.Checked) m = 1;
            double s = 0, p = 1, ch;
            double i = 1;
            switch (m)
            {
                case 0:
                    ch = 1 / i;
                    while (ch >= eps)
                    {
                        ch = (5 + i) / (3 * Factorial(i) - 1);
                        s += ch;
                        i++;
                    }

                    textBox2.Text += "При eps = " + textBox1.Text + Environment.NewLine;
                    textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
                    break;
                case 1:
                    for (i = 1; i <= n; i++)
                    {
                        ch = 0.5*Factorial(i)/(0.1*n+1);
                        p *= ch;
                    }

                    textBox2.Text += "При m = " + textBox1.Text + Environment.NewLine;
                    textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(p) + Environment.NewLine;
                    break;
                
            }
        }

        static double Factorial(double x)
        {
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}