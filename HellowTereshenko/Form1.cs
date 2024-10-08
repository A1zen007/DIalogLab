using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HellowTereshenko
{
    public partial class Form1 : Form
    {
        // Параметры для симуляции

        

        private double[][] executionTimes = 
        { 
            new double [] { 5, 2, 3, 4, 7 },
            new double [] { 12, 5, 9, 3, 4, 6, 5 }
        }; //Время выполнения шага
        private int[] stepsPerSubdialog = { 5, 7 }; // Шаги в подтемах
        private double[][] errorProbabilities = 
        { 
            new double[] { 0.1, 0.05, 0.1, 0.08, 0.07 },
            new double[] { 0.2, 0.15, 0.1, 0.12, 0.08, 0.05, 0.07 } 
        }; // Вероятности ошибок
        private double[][] routProbabilities =
        {
            new double [] { 0.2, 0.3, 0.4, 0.1 },
            new double [] { 0.4, 0.1, 0.2, 0.2, 0.1 }
        };  //Вероятность выполнение маршрута
        //private double[] executionTimes = { 2.0, 3.0 }; // Время выполнения шагов
        //private double[] subdialogProbabilities = { 0.6, 0.4 }; // Вероятности выбора подтем
        private int numSimulations = 10;
        private Random random = new Random();

        //Закон равномерного распределения
        private double ZRR()
        {
            double a = 2, b = 3;
            Random random = new Random();
            double valueRandom = random.NextDouble() * (b - a) + a;
            return valueRandom ;
        }

        //Закон экспоненциального распределения
        private double ZER()
        {
            Random random = new Random();
            double lambda = 2.0; // rate parameter
            double u = random.NextDouble();
            double x = (-1 / lambda) * Math.Log(u);
            return x;
        }
        public Form1()
        {
            InitializeComponent();
        }


        // Моделирование выполнения одной подтемы
        private double SimulateSubdialog(int subdialogIndex)
        {
            double totalTime = 0;
            int step = 0;

            ////while (step < stepsPerSubdialog[subdialogIndex])
            //{
            //    // Время выполнения шага
            //    //double time = -Math.Log(random.NextDouble()) * executionTimes[subdialogIndex];
            //    totalTime += time;

            //    // Проверка на ошибку
            //    if (random.NextDouble() < errorProbabilities[subdialogIndex][step])
            //    {
            //        // Возврат на предыдущий шаг
            //        if (step > 0) step--;
            //    }
            //    else
            //    {
            //        // Переход к следующему шагу
            //        step++;
            //    }
            //}

            return totalTime;
        }

        // Моделирование диалога
       

        // Запуск симуляции
        private void RunSimulation_Click(object sender, EventArgs e)
        {
            
            List<double> totalTimes = new List<double>();

            // Выполнение симуляций
            for (int i = 0; i < numSimulations; i++)
            {
                //totalTimes.Add(SimulateDialog());
            }

            // Вывод результатов
            double averageTime = totalTimes.Average();
            resultTextBox.Text = $"{averageTime:F2} секунд";

            // Построение гистограммы
            //PlotHistogram(totalTimes);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
