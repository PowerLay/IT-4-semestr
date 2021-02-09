using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_1_Индивидуальные_задания_12_Вариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
            label1.Text = "Начало работы";
            textBox1.Text = "";
        }
    }
}
