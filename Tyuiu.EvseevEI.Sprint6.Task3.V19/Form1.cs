using Tyuiu.EvseevEI.Sprint6.Task3.V19.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task3.V19;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();
    int[,] matrix =  { { 4, 32, -20, 27, 21 },
                            { 17,15,-1,-2,-1},
                            {-3,18,12,-10,29},
                            { 7,-15,2,-8,12 },
                            { -10,25,5,27,21} };
    private void buttonINF_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск выполнил студент группы ИИПБ - 24 - 2, Евсеев Егор Игоревич");
    }

    private void buttonRes_Click(object sender, EventArgs e)
    {
        int[,] res = new int[5, 5];
        res = ds.Calculate(matrix);

        string matrixString = "";


        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                matrixString += res[i, j] + " ";
            }
            matrixString += Environment.NewLine;
        }
        textBoxRes.Text = matrixString;
    }

    private void dataGridViewRes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        dataGridViewRes.RowCount = rows;
        dataGridViewRes.ColumnCount = columns;

        for (int i = 0; i < columns; i++)
        {
            dataGridViewRes.Columns[i].Width = 25;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                dataGridViewRes.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
            }
        }
    }
}
