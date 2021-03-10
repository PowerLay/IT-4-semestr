using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _13
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///     Левая граница графика
        /// </summary>
        private const double XMin = 0;

        /// <summary>
        ///     Шаг графика
        /// </summary>
        private const double Step = Math.PI * 2 / 10;

        /// <summary>
        ///     Правая граница графика
        /// </summary>
        private const double XMax = 5;

        private Chart _chart;

        // Массив значений X - общий для обоих графиков
        private double[] _x;

        // Два массива Y - по одному для каждого графика
        private double[] _y;

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     Расчёт значений графика
        /// </summary>
        private void CalcFunction()
        {
            // Количество точек графика
            var count = (int)Math.Ceiling((XMax - XMin) / Step)
                        + 1;
            // Создаём массивы нужных размеров
            _x = new double[count];
            _y = new double[count];
            // Рассчитываем точки для графиков функции
            for (var i = 0; i < count; i++)
            {
                // Вычисляем значение X
                _x[i] = XMin + Step * i;

                if (_x[i] <= 0 || Math.Sqrt(_x[i]) <= 0 ||
                    Math.Sin(Math.Pow(2 * _x[i], 2)) + Math.Abs(Math.Pow(Math.E, 2 * _x[i]) - 3 * Math.Pow(_x[i], 2)) == 0)continue;

                // Вычисляем значение функций в точке X
                _y[i] = 2 * Math.Log(Math.Sqrt(_x[i])) - 3 * ((_x[i] + 1) / (2 * _x[i] + 3));
                _y[i] /= Math.Sin(Math.Pow(2 * _x[i], 2)) + Math.Abs(Math.Pow(Math.E, 2 * _x[i]) - 3 * Math.Pow(_x[i], 2));
            }
        }

        /// <summary>
        ///     Создаём элемент управления Chart и настраиваем его
        /// </summary>
        private void CreateChart()
        {
            // Создаём новый элемент управления Chart
            _chart = new Chart { Parent = this };
            // Помещаем его на форму
            // Задаём размеры элемента
            _chart.SetBounds(10, 10, ClientSize.Width - 20,
                ClientSize.Height - 20);

            // Создаём новую область для построения графика
            var area = new ChartArea
            {
                // Даём ей имя (чтобы потом добавлять графики)
                Name = "myGraph",
                AxisX =
                {
                    // Задаём левую и правую границы оси X
                    Minimum = XMin,
                    Maximum = XMax,
                    // Определяем шаг сетки
                    MajorGrid = {Interval = Step}
                }
            };
            // Добавляем область в диаграмму
            _chart.ChartAreas.Add(area);

            // Создаём объект для первого графика
            var series1 = new Series
            {
                // Ссылаемся на область для построения графика
                ChartArea = "myGraph",
                // Задаем тип графика - сплайны
                ChartType = SeriesChartType.Spline,
                // Указываем ширину линии графика
                BorderWidth = 3,
                // Название графика для отображения в легенде
                LegendText = "f(x)"
            };
            // Добавляем в список графиков диаграммы
            _chart.Series.Add(series1);

            // Создаем легенду, которая будет показывать названия
            var legend = new Legend();
            _chart.Legends.Add(legend);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем элемент управления
            CreateChart();

            // Рассчитываем значения точек графиков функций
            CalcFunction();

            // Добавляем вычисленные значения в графики
            _chart.Series[0].Points.DataBindXY(_x, _y);
        }
    }
}