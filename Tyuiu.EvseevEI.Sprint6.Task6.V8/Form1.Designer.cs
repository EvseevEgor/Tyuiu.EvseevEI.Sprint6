namespace Tyuiu.EvseevEI.Sprint6.Task6.V8
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
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxVV = new TextBox();
            groupBox3 = new GroupBox();
            textBoxRes = new TextBox();
            buttonOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            buttonRes = new Button();
            buttonINF = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(1, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1589, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1580, 139);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxVV);
            groupBox2.Location = new Point(4, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(767, 572);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // textBoxVV
            // 
            textBoxVV.Location = new Point(3, 35);
            textBoxVV.Multiline = true;
            textBoxVV.Name = "textBoxVV";
            textBoxVV.Size = new Size(758, 537);
            textBoxVV.TabIndex = 0;
            textBoxVV.TextChanged += textBoxVV_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxRes);
            groupBox3.Location = new Point(790, 321);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 572);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(0, 38);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(800, 534);
            textBoxRes.TabIndex = 1;
            textBoxRes.TextChanged += textBoxRes_TextChanged;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.Coral;
            buttonOpen.ForeColor = Color.DarkBlue;
            buttonOpen.Location = new Point(12, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(150, 125);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "файл\r\nфайл\r\nфайл\r\n";
            toolTip1.SetToolTip(buttonOpen, "Открыть файл.\r\nВыберите нужный файл для обработки.");
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.CornflowerBlue;
            buttonRes.Location = new Point(200, 12);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(150, 125);
            buttonRes.TabIndex = 2;
            buttonRes.Text = "выполнить \r\nвыполнить\r\nвыполнить\r\n";
            toolTip1.SetToolTip(buttonRes, "Производит поиск\r\n");
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonINF
            // 
            buttonINF.BackColor = Color.Crimson;
            buttonINF.Location = new Point(1402, 12);
            buttonINF.Name = "buttonINF";
            buttonINF.Size = new Size(148, 125);
            buttonINF.TabIndex = 3;
            buttonINF.Text = "?      ?     ?\r\n?      ?     ?\r\n?      ?     ?";
            toolTip1.SetToolTip(buttonINF, "Сведения о программе\r\n");
            buttonINF.UseVisualStyleBackColor = false;
            buttonINF.Click += buttonINF_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1592, 905);
            Controls.Add(buttonINF);
            Controls.Add(buttonRes);
            Controls.Add(buttonOpen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Спринт 6| Таск 6| Вариант 8| Евсеев Е.И";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonOpen;
        private ToolTip toolTip1;
        private TextBox textBoxVV;
        private TextBox textBoxRes;
        private Button buttonRes;
        private Button buttonINF;
        protected internal OpenFileDialog openFileDialog1;
    }
}
