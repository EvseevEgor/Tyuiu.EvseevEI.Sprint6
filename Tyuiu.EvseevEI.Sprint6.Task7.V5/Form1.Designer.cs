namespace Tyuiu.EvseevEI.Sprint6.Task7.V5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            buttonVV = new Button();
            buttonRes = new Button();
            buttonSoh = new Button();
            buttonINF = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(0, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(870, 707);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 38);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(882, 615);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(876, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(915, 722);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(906, 600);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(12, 120);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1789, 179);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1786, 138);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonVV
            // 
            buttonVV.BackColor = Color.Coral;
            buttonVV.ForeColor = SystemColors.Desktop;
            buttonVV.Location = new Point(12, 12);
            buttonVV.Name = "buttonVV";
            buttonVV.Size = new Size(150, 109);
            buttonVV.TabIndex = 0;
            buttonVV.Text = "НАЙДИ!!!";
            buttonVV.UseVisualStyleBackColor = false;
            buttonVV.Click += buttonVV_Click;
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.Crimson;
            buttonRes.Location = new Point(212, 12);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(150, 109);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "ТЫКНИТЫКНИТЫКНИ";
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonSoh
            // 
            buttonSoh.BackColor = Color.DarkCyan;
            buttonSoh.Location = new Point(414, 12);
            buttonSoh.Name = "buttonSoh";
            buttonSoh.Size = new Size(150, 109);
            buttonSoh.TabIndex = 2;
            buttonSoh.Text = "СОХРАНИПЖ";
            buttonSoh.UseVisualStyleBackColor = false;
            buttonSoh.Click += buttonSoh_Click;
            // 
            // buttonINF
            // 
            buttonINF.BackColor = Color.DarkKhaki;
            buttonINF.Location = new Point(1611, 12);
            buttonINF.Name = "buttonINF";
            buttonINF.Size = new Size(150, 109);
            buttonINF.TabIndex = 3;
            buttonINF.Text = "????????????????\r\n????????????????\r\n????????????????\r\n\r\n\r\n\r\n";
            buttonINF.UseVisualStyleBackColor = false;
            buttonINF.Click += buttonINF_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1813, 952);
            Controls.Add(buttonINF);
            Controls.Add(buttonVV);
            Controls.Add(buttonRes);
            Controls.Add(buttonSoh);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Спринт 6| Таск 7| Вариант 5 |Евсеев Е .И";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonVV;
        private Button buttonRes;
        private Button buttonSoh;
        private Button buttonINF;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private SaveFileDialog saveFileDialog1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}
