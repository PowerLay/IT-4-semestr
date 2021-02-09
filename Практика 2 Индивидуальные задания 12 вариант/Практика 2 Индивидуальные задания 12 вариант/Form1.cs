using System;
using System.Windows.Forms;

namespace Практика_2_Индивидуальные_задания_12_вариант
{
    public partial class Form1 : Form
    {
        // Методы окна
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            // Вывод строки в многострочный редактор
            textBox2.Text = "Практическая работа №1 Козлуков О.В.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения y=x^2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            var x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox2.Text += Environment.NewLine +
                             "При x = " + x;
            // Вычисляем арифметическое выражение
            //var y = Math.Sqrt(3 + (Math.Log(x) + 15 - x));
            //y = y / (1 + Math.Sin((2 + Math.Pow(x, 2)) / (1 + x)));

            var y = Math.Pow(Math.E, x - Math.Sqrt(x));
            y = y / (Math.Log((x + 5) / (x + 1)) - 2 * (Math.Pow(x, 3) + x) / (1 + Math.Abs(Math.Sin(x))));

            // Выводим результат в окно
            textBox2.Text += Environment.NewLine +
                             "Результат y = " + y;
        }
    }
}