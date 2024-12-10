using System.Linq.Expressions;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.EvseevEI.Sprint6.Task2.V18.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task2.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_Done_Click(object sender, EventArgs e)
        {

            int startStep = Convert.ToInt32(textBoxStartStep.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep.Text);
            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startStep, stopStep);
            this.chartFunction.Titles.Add("График функции ");
            this.chartFunction.ChartAreas[0] . AxisX.Title = "Ось X";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                startStep++;
            }

        }
       
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
