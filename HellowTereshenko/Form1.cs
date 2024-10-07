using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HellowTereshenko
{
    public partial class Form1 : Form
    {
        // Параметры для симуляции
        private int[] stepsPerSubdialog = { 5, 7 }; // Шаги в подтемах
        private double[][] errorProbabilities = { new double[] { 0.1, 0.05, 0.1, 0.08, 0.07 },
                                                  new double[] { 0.2, 0.15, 0.1, 0.12, 0.08, 0.05, 0.07 } }; // Вероятности ошибок
        private double[] executionTimes = { 2.0, 3.0 }; // Время выполнения шагов
        private double[] subdialogProbabilities = { 0.6, 0.4 }; // Вероятности выбора подтем

        private int numSimulations = 1000;
        private Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }


        // Моделирование выполнения одной подтемы
        private double SimulateSubdialog(int subdialogIndex)
        {
            double totalTime = 0;
            int step = 0;

            while (step < stepsPerSubdialog[subdialogIndex])
            {
                // Время выполнения шага
                double time = -Math.Log(random.NextDouble()) * executionTimes[subdialogIndex];
                totalTime += time;

                // Проверка на ошибку
                if (random.NextDouble() < errorProbabilities[subdialogIndex][step])
                {
                    // Возврат на предыдущий шаг
                    if (step > 0) step--;
                }
                else
                {
                    // Переход к следующему шагу
                    step++;
                }
            }

            return totalTime;
        }

        // Моделирование диалога
        private double SimulateDialog()
        {
            // Выбор подтемы
            int subdialogChoice = random.NextDouble() < subdialogProbabilities[0] ? 0 : 1;

            // Выполнение подтемы
            return SimulateSubdialog(subdialogChoice);
        }

        // Запуск симуляции
        private void RunSimulation_Click(object sender, EventArgs e)
        {
            List<double> totalTimes = new List<double>();

            // Выполнение симуляций
            for (int i = 0; i < numSimulations; i++)
            {
                totalTimes.Add(SimulateDialog());
            }

            // Вывод результатов
            double averageTime = totalTimes.Average();
            resultTextBox.Text = $"Среднее время выполнения задачи: {averageTime:F2} секунд";

            // Построение гистограммы
            PlotHistogram(totalTimes);
        }
        private void PlotHistogram(List<double> data)
        {
            histogramChart.Series.Clear();
            histogramChart.Titles.Clear();

            histogramChart.Titles.Add("Гистограмма времени выполнения");
            var series = new Series
            {
                Name = "Execution Time",
                ChartType = SeriesChartType.Column
            };
            histogramChart.Series.Add(series);

            var dataGrouped = data.GroupBy(d => Math.Floor(d)).ToDictionary(g => g.Key, g => g.Count());
            foreach (var entry in dataGrouped)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
