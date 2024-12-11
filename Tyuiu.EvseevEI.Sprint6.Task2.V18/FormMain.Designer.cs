namespace Tyuiu.EvseevEI.Sprint6.Task2.V18
{
    partial class FormMain
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
            textBox1 = new TextBox();
            button_Done = new Button();
            buttonINF = new Button();
            groupBox2 = new GroupBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBox4 = new TextBox();
            DataGridViewFunction = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 439);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Azure;
            textBox1.Location = new Point(9, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(657, 111);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию  на заданном диапазоне";
            textBox1.WordWrap = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button_Done
            // 
            button_Done.AccessibleName = "button_Done";
            button_Done.BackColor = Color.CornflowerBlue;
            button_Done.ForeColor = Color.DarkSlateBlue;
            button_Done.Location = new Point(632, 515);
            button_Done.Name = "button_Done";
            button_Done.Size = new Size(208, 110);
            button_Done.TabIndex = 2;
            button_Done.Text = "Выполнить";
            button_Done.UseVisualStyleBackColor = false;
            button_Done.Click += button_Done_Click;
            // 
            // buttonINF
            // 
            buttonINF.BackColor = Color.Coral;
            buttonINF.Location = new Point(476, 515);
            buttonINF.Name = "buttonINF";
            buttonINF.Size = new Size(150, 110);
            buttonINF.TabIndex = 3;
            buttonINF.Text = "Справка";
            buttonINF.UseVisualStyleBackColor = false;
            buttonINF.Click += ButtonINF;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStopStep);
            groupBox2.Controls.Add(textBoxStartStep);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(12, 461);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 183);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.AccessibleName = "textBoxStopStep";
            textBoxStopStep.Location = new Point(241, 125);
            textBoxStopStep.Multiline = true;
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(200, 58);
            textBoxStopStep.TabIndex = 5;
            textBoxStopStep.TextChanged += textBoxStopStep_TextChanged;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.AccessibleName = "textBoxStartStep";
            textBoxStartStep.Location = new Point(6, 125);
            textBoxStartStep.Multiline = true;
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(200, 58);
            textBoxStartStep.TabIndex = 4;
            textBoxStartStep.TextChanged += textBoxStartStep_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.AliceBlue;
            textBox3.Location = new Point(241, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 3;
            textBox3.Text = "Конец шага";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AliceBlue;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(6, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 39);
            textBox2.TabIndex = 2;
            textBox2.Text = "Старт шага";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(chartFunction);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(DataGridViewFunction);
            groupBox3.Location = new Point(846, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(899, 659);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartFunction.AccessibleName = "chartFunction";
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(349, 53);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(544, 600);
            chartFunction.TabIndex = 2;
            chartFunction.Text = "chart1";
            chartFunction.Click += chartFunction_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.HighlightText;
            textBox4.Location = new Point(3, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(272, 39);
            textBox4.TabIndex = 1;
            textBox4.Text = "Результат";
            // 
            // DataGridViewFunction
            // 
            DataGridViewFunction.AccessibleName = "DataGridViewFunction";
            DataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            DataGridViewFunction.Location = new Point(6, 86);
            DataGridViewFunction.Name = "DataGridViewFunction";
            DataGridViewFunction.RowHeadersVisible = false;
            DataGridViewFunction.RowHeadersWidth = 82;
            DataGridViewFunction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewFunction.Size = new Size(269, 567);
            DataGridViewFunction.TabIndex = 0;
            DataGridViewFunction.CellContentClick += DataGridViewFunction_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(x)";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 130;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1781, 702);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(buttonINF);
            Controls.Add(button_Done);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6| Таск 2 |Вариант 18| Евсеев Е.И";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_Done;
        private Button buttonINF;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private DataGridView DataGridViewFunction;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
    }
}
