using System;
using System.Windows.Forms;

namespace Практика_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToDouble(textBox1.Text);
            var eps = Convert.ToDouble(textBox1.Text);
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
                        ch = 1 / i;
                        s += ch;
                        i++;
                    }

                    textBox2.Text += "При eps = " + textBox1.Text + Environment.NewLine;
                    textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
                    break;
                case 1:
                    for (i = 1; i <= n; i++)
                    {
                        ch = i;
                        p *= ch;
                    }

                    textBox2.Text += "При m = " + textBox1.Text + Environment.NewLine;
                    textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(p) + Environment.NewLine;
                    break;
            }
        }
    }
}