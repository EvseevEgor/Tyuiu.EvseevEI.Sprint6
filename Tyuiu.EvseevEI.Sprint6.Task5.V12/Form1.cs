using Tyuiu.EvseevEI.Sprint6.Task5.V12.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task5.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\evseevegor709icloud\source\repos\Tyuiu.EvseevEI.Sprint6\Tyuiu.EvseevEI.Sprint6.Task5.V12\input.txt";


        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonINF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент группы ИИПБ - 24 - 2, Евсеев Егор Игоревич");
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {

            dataGridViewRes.ColumnCount = 2;
            dataGridViewRes.Columns[0].Width = 20;
            dataGridViewRes.Columns[1].Width = 50;

            this.chartRes.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartRes.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartRes.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void dataGridViewRes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartRes_Click(object sender, EventArgs e)
        {

        }
    }
}
