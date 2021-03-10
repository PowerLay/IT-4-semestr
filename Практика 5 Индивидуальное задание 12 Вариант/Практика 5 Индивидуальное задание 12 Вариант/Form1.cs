using System;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = listBox1.Items[listBox1.SelectedIndex].ToString();

            str = str.Replace(" ", "");

            label1.Text = "Строка: \"" + str + "\"";
        }
    }
}