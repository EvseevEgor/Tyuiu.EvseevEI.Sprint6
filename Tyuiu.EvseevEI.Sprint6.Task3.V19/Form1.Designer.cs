namespace Tyuiu.EvseevEI.Sprint6.Task3.V19;

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
        dataGridViewRes = new DataGridView();
        groupBox1 = new GroupBox();
        textBox2 = new TextBox();
        groupBox2 = new GroupBox();
        textBoxRes = new TextBox();
        buttonINF = new Button();
        button2 = new Button();
        Column1 = new DataGridViewTextBoxColumn();
        Column2 = new DataGridViewTextBoxColumn();
        Column3 = new DataGridViewTextBoxColumn();
        Column4 = new DataGridViewTextBoxColumn();
        Column5 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridViewRes
        // 
        dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewRes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
        dataGridViewRes.Enabled = false;
        dataGridViewRes.Location = new Point(638, 52);
        dataGridViewRes.Name = "dataGridViewRes";
        dataGridViewRes.RowHeadersWidth = 82;
        dataGridViewRes.Size = new Size(506, 462);
        dataGridViewRes.TabIndex = 0;
        dataGridViewRes.CellContentClick += dataGridViewRes_CellContentClick;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBox2);
        groupBox1.Location = new Point(12, 43);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(620, 464);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(3, 44);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(611, 489);
        textBox2.TabIndex = 0;
        textBox2.Text = " Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в пятом столбце.";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(textBoxRes);
        groupBox2.Location = new Point(1167, 52);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(302, 524);
        groupBox2.TabIndex = 0;
        groupBox2.TabStop = false;
        groupBox2.Text = "Вывод данных";
        // 
        // textBoxRes
        // 
        textBoxRes.AccessibleName = "textBoxRes";
        textBoxRes.Location = new Point(3, 35);
        textBoxRes.Multiline = true;
        textBoxRes.Name = "textBoxRes";
        textBoxRes.Size = new Size(299, 303);
        textBoxRes.TabIndex = 0;
        // 
        // buttonINF
        // 
        buttonINF.AccessibleName = "buttonINF";
        buttonINF.BackColor = Color.Coral;
        buttonINF.Location = new Point(1129, 582);
        buttonINF.Name = "buttonINF";
        buttonINF.Size = new Size(86, 85);
        buttonINF.TabIndex = 0;
        buttonINF.Text = "?";
        buttonINF.UseVisualStyleBackColor = false;
        buttonINF.Click += buttonINF_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.CornflowerBlue;
        button2.Location = new Point(1266, 582);
        button2.Name = "button2";
        button2.Size = new Size(203, 85);
        button2.TabIndex = 1;
        button2.Text = "Выполнить";
        button2.UseVisualStyleBackColor = false;
        button2.Click += buttonRes_Click;
        // 
        // Column1
        // 
        Column1.HeaderText = "1";
        Column1.MinimumWidth = 10;
        Column1.Name = "Column1";
        Column1.Width = 80;
        // 
        // Column2
        // 
        Column2.HeaderText = "2";
        Column2.MinimumWidth = 10;
        Column2.Name = "Column2";
        Column2.Width = 80;
        // 
        // Column3
        // 
        Column3.HeaderText = "3";
        Column3.MinimumWidth = 10;
        Column3.Name = "Column3";
        Column3.Width = 80;
        // 
        // Column4
        // 
        Column4.HeaderText = "4";
        Column4.MinimumWidth = 10;
        Column4.Name = "Column4";
        Column4.Width = 80;
        // 
        // Column5
        // 
        Column5.HeaderText = "5";
        Column5.MinimumWidth = 10;
        Column5.Name = "Column5";
        Column5.Width = 80;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1497, 678);
        Controls.Add(buttonINF);
        Controls.Add(button2);
        Controls.Add(dataGridViewRes);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "Form1";
        Text = "Спринт 6| Таск 3| Вариант 19| Евсеев Е.И";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private DataGridView dataGridViewRes;
    private TextBox textBox2;
    private TextBox textBoxRes;
    private Button buttonINF;
    private Button button2;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
}
