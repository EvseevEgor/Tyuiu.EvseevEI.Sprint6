namespace Tyuiu.EvseevEI.Sprint6.Task7.V5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonclose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_12_12_14_27_21;
            pictureBox1.Location = new Point(-145, -198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(506, 688);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(759, 481);
            label1.TabIndex = 1;
            label1.Text = "Разработчик: Евсеев Егор Игоревич \r\nгруппа:ИИПБ-24-2\r\nВШЦТ\r\n";
            // 
            // buttonclose
            // 
            buttonclose.BackColor = Color.DarkCyan;
            buttonclose.Location = new Point(826, 589);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(287, 77);
            buttonclose.TabIndex = 2;
            buttonclose.Text = "close";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 695);
            Controls.Add(buttonclose);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "ПАпик";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonclose;
    }
}