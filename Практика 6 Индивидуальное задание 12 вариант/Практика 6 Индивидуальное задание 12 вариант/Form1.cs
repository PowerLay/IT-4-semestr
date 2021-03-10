using System;
using System.Linq;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        private readonly int[] Mas = new int[15];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            textBox1.Text = "";
            for (var i = 0; i < 15; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
                                 + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var average = Mas.Average();
            var geomAverage = Math.Pow(Math.Abs(Mas.Aggregate((x, y) => x * y)), 1.0 / Mas.Length);
            textBox2.Text = $"Среднее арифметическое значение = {average}" + Environment.NewLine;
            textBox2.Text += $"Среднее геометрическое значение = {geomAverage}" + Environment.NewLine;
        }
    }
}