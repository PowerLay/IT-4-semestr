﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble((textBox1.Text));
            b = Convert.ToDouble((textBox2.Text));

            switch (comboBox1.Text)
            {
                case "+":
                    textBox4.Text = $"{a + b}";
                    break;
                case "-":
                    textBox4.Text = $"{a - b}";
                    break;
                case "*":
                    textBox4.Text = $"{a * b}";
                    break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя");
                        break;
                    }
                    textBox4.Text = $"{a / b}";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }
    }
}
