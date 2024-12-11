
namespace Tyuiu.EvseevEI.Sprint6.Task0.V9;

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
        Condition_EEI = new GroupBox();
        textBoxOne_EEI = new TextBox();
        textBoxTwo_EEI = new TextBox();
        pictureBox_EEI = new PictureBox();
        groupBoxObsh_EEI = new GroupBox();
        groupBoxResult_EEI = new GroupBox();
        textBox_Result_EEI = new TextBox();
        buttonResult_EEI = new Button();
        button_Clickno_EEI = new Button();
        Textbox_click_EEI = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox_EEI).BeginInit();
        groupBoxObsh_EEI.SuspendLayout();
        groupBoxResult_EEI.SuspendLayout();
        SuspendLayout();
        // 
        // Condition_EEI
        // 
        Condition_EEI.AccessibleName = "Condition_EEI";
        Condition_EEI.Enabled = false;
        Condition_EEI.Location = new Point(0, 0);
        Condition_EEI.Name = "Condition_EEI";
        Condition_EEI.Size = new Size(400, 42);
        Condition_EEI.TabIndex = 0;
        Condition_EEI.TabStop = false;
        Condition_EEI.Text = "Условие";
        // 
        // textBoxOne_EEI
        // 
        textBoxOne_EEI.AccessibleName = "textBoxOne_EEI";
        textBoxOne_EEI.BackColor = SystemColors.ButtonFace;
        textBoxOne_EEI.Enabled = false;
        textBoxOne_EEI.Location = new Point(0, 48);
        textBoxOne_EEI.Multiline = true;
        textBoxOne_EEI.Name = "textBoxOne_EEI";
        textBoxOne_EEI.Size = new Size(919, 272);
        textBoxOne_EEI.TabIndex = 0;
        textBoxOne_EEI.Text = "Вычислить выражение по формуле";
        // 
        // textBoxTwo_EEI
        // 
        textBoxTwo_EEI.BackColor = SystemColors.Control;
        textBoxTwo_EEI.Enabled = false;
        textBoxTwo_EEI.Location = new Point(0, 387);
        textBoxTwo_EEI.Multiline = true;
        textBoxTwo_EEI.Name = "textBoxTwo_EEI";
        textBoxTwo_EEI.Size = new Size(611, 183);
        textBoxTwo_EEI.TabIndex = 2;
        textBoxTwo_EEI.Text = "Ввод данных";
        // 
        // pictureBox_EEI
        // 
        pictureBox_EEI.AccessibleName = "pictureBox_EEI";
        pictureBox_EEI.Enabled = false;
        pictureBox_EEI.Image = Properties.Resources.Снимок_экрана_2024_12_02_в_00_43_00;
        pictureBox_EEI.Location = new Point(655, 48);
        pictureBox_EEI.Name = "pictureBox_EEI";
        pictureBox_EEI.Size = new Size(260, 149);
        pictureBox_EEI.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox_EEI.TabIndex = 3;
        pictureBox_EEI.TabStop = false;
        // 
        // groupBoxObsh_EEI
        // 
        groupBoxObsh_EEI.AccessibleName = "groupBoxObsh_EEI";
        groupBoxObsh_EEI.Controls.Add(groupBoxResult_EEI);
        groupBoxObsh_EEI.Location = new Point(617, 350);
        groupBoxObsh_EEI.Name = "groupBoxObsh_EEI";
        groupBoxObsh_EEI.Size = new Size(302, 220);
        groupBoxObsh_EEI.TabIndex = 7;
        groupBoxObsh_EEI.TabStop = false;
        groupBoxObsh_EEI.Text = "Вывод данных";
        // 
        // groupBoxResult_EEI
        // 
        groupBoxResult_EEI.AccessibleName = "groupBoxResult_EEI";
        groupBoxResult_EEI.Controls.Add(textBox_Result_EEI);
        groupBoxResult_EEI.Location = new Point(3, 83);
        groupBoxResult_EEI.Name = "groupBoxResult_EEI";
        groupBoxResult_EEI.Size = new Size(293, 137);
        groupBoxResult_EEI.TabIndex = 2;
        groupBoxResult_EEI.TabStop = false;
        groupBoxResult_EEI.Text = "Результат";
        // 
        // textBox_Result_EEI
        // 
        textBox_Result_EEI.AccessibleName = "textBox_Result_EEI";
        textBox_Result_EEI.Enabled = false;
        textBox_Result_EEI.ForeColor = Color.Aquamarine;
        textBox_Result_EEI.Location = new Point(0, 51);
        textBox_Result_EEI.Multiline = true;
        textBox_Result_EEI.Name = "textBox_Result_EEI";
        textBox_Result_EEI.Size = new Size(302, 86);
        textBox_Result_EEI.TabIndex = 1;
        textBox_Result_EEI.TextChanged += textBox_Result_EEI_TextChanged_1;
        // 
        // buttonResult_EEI
        // 
        buttonResult_EEI.AccessibleName = "buttonResult_EEI";
        buttonResult_EEI.BackColor = SystemColors.ControlDark;
        buttonResult_EEI.Location = new Point(697, 585);
        buttonResult_EEI.Name = "buttonResult_EEI";
        buttonResult_EEI.Size = new Size(207, 58);
        buttonResult_EEI.TabIndex = 3;
        buttonResult_EEI.Text = "Выполнить";
        buttonResult_EEI.UseVisualStyleBackColor = false;
        buttonResult_EEI.Click += ButtonResult_EEI_Click;
        // 
        // button_Clickno_EEI
        // 
        button_Clickno_EEI.AccessibleName = "button_Clickno_EEI";
        button_Clickno_EEI.BackColor = SystemColors.ControlDark;
        button_Clickno_EEI.Location = new Point(596, 588);
        button_Clickno_EEI.Name = "button_Clickno_EEI";
        button_Clickno_EEI.Size = new Size(82, 55);
        button_Clickno_EEI.TabIndex = 11;
        button_Clickno_EEI.Text = "?";
        button_Clickno_EEI.UseVisualStyleBackColor = false;
        button_Clickno_EEI.Click += Button_Clickno_EEI_Click;
        // 
        // Textbox_click_EEI
        // 
        Textbox_click_EEI.AccessibleName = "Textbox_click_EEI";
        Textbox_click_EEI.Location = new Point(37, 448);
        Textbox_click_EEI.Multiline = true;
        Textbox_click_EEI.Name = "Textbox_click_EEI";
        Textbox_click_EEI.Size = new Size(397, 86);
        Textbox_click_EEI.TabIndex = 12;
        Textbox_click_EEI.TextChanged += Textbox_click_EEI_TextChanged;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(927, 664);
        Controls.Add(Textbox_click_EEI);
        Controls.Add(button_Clickno_EEI);
        Controls.Add(buttonResult_EEI);
        Controls.Add(groupBoxObsh_EEI);
        Controls.Add(pictureBox_EEI);
        Controls.Add(textBoxTwo_EEI);
        Controls.Add(textBoxOne_EEI);
        Controls.Add(Condition_EEI);
        Name = "FormMain";
        Text = "Спринт 6 | Таск 0 | Вариант 9 | Евсеев Е.И ";
        Load += FormMain_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox_EEI).EndInit();
        groupBoxObsh_EEI.ResumeLayout(false);
        groupBoxResult_EEI.ResumeLayout(false);
        groupBoxResult_EEI.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox Condition_EEI;
    private TextBox textBoxOne_EEI;
    private TextBox textBoxTwo_EEI;
    private PictureBox pictureBox_EEI;
    private GroupBox groupBoxObsh_EEI;
    private TextBox textBox_Result_EEI;
    private GroupBox groupBoxResult_EEI;
    private Button buttonResult_EEI;
    private Button button_Clickno_EEI;
    private TextBox Textbox_click_EEI;
}
