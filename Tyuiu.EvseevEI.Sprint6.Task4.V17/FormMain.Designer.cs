
namespace Tyuiu.EvseevEI.Sprint6.Task4.V17
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
            textBoxRes = new TextBox();
            buttonRes = new Button();
            buttonSoh = new Button();
            buttonINF = new Button();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox4 = new GroupBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 61);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(388, 714);
            textBoxRes.TabIndex = 0;
            textBoxRes.TextChanged += textBox1_TextChanged;
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.Crimson;
            buttonRes.Location = new Point(1181, 41);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(150, 115);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "Выполнить";
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonSoh
            // 
            buttonSoh.BackColor = Color.CornflowerBlue;
            buttonSoh.Location = new Point(1347, 41);
            buttonSoh.Name = "buttonSoh";
            buttonSoh.Size = new Size(150, 115);
            buttonSoh.TabIndex = 2;
            buttonSoh.Text = "Сохранить";
            buttonSoh.UseVisualStyleBackColor = false;
            // 
            // buttonINF
            // 
            buttonINF.BackColor = Color.Coral;
            buttonINF.ForeColor = Color.Black;
            buttonINF.Location = new Point(1646, 45);
            buttonINF.Name = "buttonINF";
            buttonINF.Size = new Size(150, 111);
            buttonINF.TabIndex = 3;
            buttonINF.Text = "Справка";
            buttonINF.UseVisualStyleBackColor = false;
            buttonINF.Click += buttonINF_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 56);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1133, 138);
            textBox2.TabIndex = 4;
            textBox2.Text = "Протабулировать функцию  на заданном диапазоне от 5 до 5.";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(29, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 200);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxRes);
            groupBox2.Location = new Point(12, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 775);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "вывод";
            // 
            // chartRes
            // 
            chartArea1.Name = "ChartArea1";
            chartRes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes.Legends.Add(legend1);
            chartRes.Location = new Point(435, 246);
            chartRes.Name = "chartRes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes.Series.Add(series1);
            chartRes.Size = new Size(1361, 761);
            chartRes.TabIndex = 8;
            chartRes.Text = "chart1";
            chartRes.Click += chartRes_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxStop);
            groupBox4.Controls.Add(textBoxStart);
            groupBox4.Location = new Point(751, 30);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(424, 179);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "ввод данных";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(224, 125);
            textBoxStop.Multiline = true;
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(200, 48);
            textBoxStop.TabIndex = 1;
            textBoxStop.TextChanged += textBoxStop_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.AccessibleName = "textBoxStart";
            textBoxStart.Location = new Point(0, 125);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(200, 48);
            textBoxStart.TabIndex = 0;
            textBoxStart.TextChanged += textBoxStart_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1808, 1033);
            Controls.Add(groupBox4);
            Controls.Add(chartRes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonINF);
            Controls.Add(buttonSoh);
            Controls.Add(buttonRes);
            Name = "FormMain";
            Text = "Спринт 6| Таск 4| Вариант 17| Евсеев Е.И";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
        private Button buttonRes;
        private Button buttonSoh;
        private Button buttonINF;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
    }
}
