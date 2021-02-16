using System;
using System.Windows.Forms;

namespace Практика_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            var z = Convert.ToDouble(textBox3.Text);
            // Ввод исходных данных в окно результатов
            textBox4.Text = "Результаты работы программы ст. Иванова И.И. " + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;
            var n = 0;
            if (radioButton2.Checked) n = 1;
            else if (radioButton3.Checked) n = 2;
            // Вычисление U
            double u;
            switch (n)
            {
                case 0:
                    if (z >= 3) u = Math.Sinh(z) - 2;
                    else if (-2 < z && z < 3) u = 0.5 * Math.Sinh(z);
                    else u = -2;
                    textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;
                case 1:
                    if (z >= 3) u = Math.Cosh(z)- 2;
                    else if (-2 < z && z < 3) u = 0.5 * Math.Cosh(z);
                    else u = -2;
                    textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;
                case 2:
                    if (z >= 3) u = Math.Exp(z)- 2;
                    else if (-2 < z && z < 3) u = 0.5 * Math.Exp(z);
                    else u = -2;
                    textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;
                default:
                    textBox4.Text += "Решение не найдено" + Environment.NewLine;
                    break;

            }
        }
    }
}