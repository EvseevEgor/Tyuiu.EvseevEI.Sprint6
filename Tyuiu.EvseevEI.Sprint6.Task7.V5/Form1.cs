using Tyuiu.EvseevEI.Sprint6.Task7.V5.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task7.V5
{
    public partial class Form1 : Form
    {
        DataService ds = new();
        public Form1()
        {
            InitializeComponent();
         }
        static int rows;
        static int columns;
        static string path;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private int[,] LoadFromFileDFate(string filename)
        {
            string text = File.ReadAllText(path);
            text = text.Replace('\n', '\r');
            string[] lines = text.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return array;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonINF_Click(object sender, EventArgs e)
        {
            Form2 fa = new Form2();
            fa.ShowDialog();
        }

        private void buttonSoh_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridView1.Rows.Count;
            int columns = dataGridView1.Columns.Count;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView1.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        
    }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void buttonVV_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileDFate(path);

            dataGridView2.ColumnCount = columns;
            dataGridView2.RowCount = rows;
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridView2.Columns[i].Width = 60;
                dataGridView1.Columns[i].Width = 60;
            }

            arrayValues = LoadFromFileDFate(openFileDialog1);
            buttonRes.Enabled = true;
        }

        private int[,] LoadFromFileDFate(OpenFileDialog openFileDialog1)
        {
            throw new NotImplementedException();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int[,] result = ds.GetMatrix(path);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = result[i, j];
                }
            }
            buttonSoh.Enabled = true;
        }
    }
}
