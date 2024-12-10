using Tyuiu.EvseevEI.Sprint6.Task4.V17.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task4.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


            DataService ds = new DataService();

            private void buttonDone_Click(object sender, EventArgs e)
            {
                try
                {
                    int startValue = Convert.ToInt32(textBoxStartValue_EEI.Text);
                    int stopValue = Convert.ToInt32(textBoxStopValue_EEI.Text);

                    int len = stopValue - startValue + 1;

                    double[] valueArray = new double[len];

                    valueArray = ds.GetMassFunction(startValue, stopValue);

                    this.chartFunction_EEI.ChartAreas[0].AxisX.Title = "Îñü X";
                    this.chartFunction_EEI.ChartAreas[0].AxisY.Title = "Îñü Y";

                textBoxResult_EEI.Text = "";

                chartFunction_EEI.Series[0].Points.Clear();

                    for (int i = 0; i < len; i++)
                {
                    this.chartFunction_EEI.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxResult_EEI.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 4 âûïîëíèë ñòóäåíò ãðóïïû ÏÊÒá-24-1 ×èãóðîâ Ìàêñèì Âëàäèñëàâîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4.txt" });
                File.WriteAllText(path, textBoxResult_EEI.Text);

                DialogResult dialogResult = MessageBox.Show("Ôàéë" + path + " ñîõðàíåí óñïåøíî! \n Îòêðûòü åãî â áëîêíîòå?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè ñîõðàíåíèè ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
    
}
