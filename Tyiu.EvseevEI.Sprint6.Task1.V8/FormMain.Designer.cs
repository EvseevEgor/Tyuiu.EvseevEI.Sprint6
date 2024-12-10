namespace Tyiu.EvseevEI.Sprint6.Task1.V8
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Cornsilk;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 437);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(27, 498);
            button1.Name = "button1";
            button1.Size = new Size(188, 46);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(274, 498);
            button2.Name = "button2";
            button2.Size = new Size(209, 46);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Coral;
            button3.Location = new Point(529, 467);
            button3.Name = "button3";
            button3.Size = new Size(133, 108);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.Location = new Point(695, 467);
            button4.Name = "button4";
            button4.Size = new Size(125, 108);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(844, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 437);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Azure;
            textBox1.Location = new Point(3, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(632, 78);
            textBox1.TabIndex = 0;
            textBox1.Text = "(произвести табулирование) f(x) на заданном диапазоне [-5; 5]";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 627);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6| Таск 1| Вариант 8| Евсеев Е.И";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
