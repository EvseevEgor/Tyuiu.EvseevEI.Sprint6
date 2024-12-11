namespace Tyuiu.EvseevEI.Sprint6.Task5.V12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            buttonINF = new Button();
            buttonOpen = new Button();
            buttonRes = new Button();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewRes = new DataGridView();
            chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonINF);
            groupBox1.Controls.Add(buttonOpen);
            groupBox1.Controls.Add(buttonRes);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1749, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // buttonINF
            // 
            buttonINF.BackColor = Color.CornflowerBlue;
            buttonINF.Location = new Point(1577, 38);
            buttonINF.Name = "buttonINF";
            buttonINF.Size = new Size(150, 139);
            buttonINF.TabIndex = 3;
            buttonINF.Text = "Справка";
            buttonINF.UseVisualStyleBackColor = false;
            buttonINF.Click += buttonINF_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.DarkCyan;
            buttonOpen.Location = new Point(1388, 38);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(150, 139);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.DarkGoldenrod;
            buttonRes.Location = new Point(1203, 38);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(150, 139);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "Выполнить";
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.Click += buttonRes_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 35);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1160, 165);
            textBox2.TabIndex = 0;
            textBox2.Text = "Прочитать данные из файла InPut File Task5.bt. Вывести в dataGridView  все числа не кратные 5 и построить диаграмму по этим значениям.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewRes);
            groupBox2.Location = new Point(12, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 694);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.Location = new Point(0, 38);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersWidth = 82;
            dataGridViewRes.Size = new Size(400, 685);
            dataGridViewRes.TabIndex = 1;
            dataGridViewRes.CellContentClick += dataGridViewRes_CellContentClick;
            // 
            // chartRes
            // 
            chartArea1.Name = "ChartArea1";
            chartRes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes.Legends.Add(legend1);
            chartRes.Location = new Point(418, 209);
            chartRes.Name = "chartRes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes.Series.Add(series1);
            chartRes.Size = new Size(1343, 685);
            chartRes.TabIndex = 0;
            chartRes.Click += chartRes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1761, 906);
            Controls.Add(chartRes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Спринт 6| Таск 5| Вариант 12| Евсеев Е.И";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonRes;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Button buttonINF;
        private Button buttonOpen;
        private DataGridView dataGridViewRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
    }
}
