namespace HellowTereshenko
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stepsPerSubdialog_textbox1 = new System.Windows.Forms.TextBox();
            this.stepsPerSubdialog_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.executionTimes_textBox2 = new System.Windows.Forms.TextBox();
            this.executionTimes_textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.subdialogProbabilities_textBox2 = new System.Windows.Forms.TextBox();
            this.subdialogProbabilities_textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(889, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RunSimulation_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 21);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(989, 331);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(326, 390);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(129, 26);
            this.resultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Среднее время выполнения задачи:";
            // 
            // stepsPerSubdialog_textbox1
            // 
            this.stepsPerSubdialog_textbox1.Location = new System.Drawing.Point(1365, 34);
            this.stepsPerSubdialog_textbox1.Name = "stepsPerSubdialog_textbox1";
            this.stepsPerSubdialog_textbox1.Size = new System.Drawing.Size(63, 26);
            this.stepsPerSubdialog_textbox1.TabIndex = 4;
            // 
            // stepsPerSubdialog_textBox2
            // 
            this.stepsPerSubdialog_textBox2.Location = new System.Drawing.Point(1365, 66);
            this.stepsPerSubdialog_textBox2.Name = "stepsPerSubdialog_textBox2";
            this.stepsPerSubdialog_textBox2.Size = new System.Drawing.Size(63, 26);
            this.stepsPerSubdialog_textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во шагов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1270, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "1 подтема";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1270, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "2 подтема";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1270, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "2 подтема";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1270, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "1 подтема";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1289, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Время шага";
            // 
            // executionTimes_textBox2
            // 
            this.executionTimes_textBox2.Location = new System.Drawing.Point(1365, 165);
            this.executionTimes_textBox2.Name = "executionTimes_textBox2";
            this.executionTimes_textBox2.Size = new System.Drawing.Size(63, 26);
            this.executionTimes_textBox2.TabIndex = 10;
            // 
            // executionTimes_textBox1
            // 
            this.executionTimes_textBox1.Location = new System.Drawing.Point(1365, 133);
            this.executionTimes_textBox1.Name = "executionTimes_textBox1";
            this.executionTimes_textBox1.Size = new System.Drawing.Size(63, 26);
            this.executionTimes_textBox1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1270, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "2 подтема";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1270, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "1 подтема";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1270, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Вероятность выбора";
            // 
            // subdialogProbabilities_textBox2
            // 
            this.subdialogProbabilities_textBox2.Location = new System.Drawing.Point(1365, 259);
            this.subdialogProbabilities_textBox2.Name = "subdialogProbabilities_textBox2";
            this.subdialogProbabilities_textBox2.Size = new System.Drawing.Size(63, 26);
            this.subdialogProbabilities_textBox2.TabIndex = 15;
            // 
            // subdialogProbabilities_textBox1
            // 
            this.subdialogProbabilities_textBox1.Location = new System.Drawing.Point(1365, 227);
            this.subdialogProbabilities_textBox1.Name = "subdialogProbabilities_textBox1";
            this.subdialogProbabilities_textBox1.Size = new System.Drawing.Size(63, 26);
            this.subdialogProbabilities_textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.subdialogProbabilities_textBox2);
            this.Controls.Add(this.subdialogProbabilities_textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.executionTimes_textBox2);
            this.Controls.Add(this.executionTimes_textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stepsPerSubdialog_textBox2);
            this.Controls.Add(this.stepsPerSubdialog_textbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stepsPerSubdialog_textbox1;
        private System.Windows.Forms.TextBox stepsPerSubdialog_textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox executionTimes_textBox2;
        private System.Windows.Forms.TextBox executionTimes_textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox subdialogProbabilities_textBox2;
        private System.Windows.Forms.TextBox subdialogProbabilities_textBox1;
    }
}

