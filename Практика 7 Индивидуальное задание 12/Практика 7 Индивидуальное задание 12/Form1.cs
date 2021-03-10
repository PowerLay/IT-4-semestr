using System;
using System.Windows.Forms;

namespace Практика_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var size = 5;
            dataGridView1.RowCount = size; //Указываем количество строк
            dataGridView1.ColumnCount = size; //Указываем количество столбцов
            var a = new int[size, size]; //Инициализируем массив
            //Заполняем матрицу случайными числами
            var rand = new Random();
            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                    a[i, j] = rand.Next(-100, 100);
            //Выводим матрицу в dataGridView1
            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);

            var ans = new[] { 0, 0 };

            var max = int.MinValue;
            var maxIndex = -1;
            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        maxIndex = i;
                    }

            var min = int.MaxValue;
            var minIndex = -1;

            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        minIndex = i;
                    }

            for (var i = 0; i < size; i++)
            {
                ans[0] += a[maxIndex, i];
                ans[1] = a[minIndex, i];
            }

            // выводим результат
            textBox1.Text = $"{ans[0]}, {ans[1]}";
        }
    }
}