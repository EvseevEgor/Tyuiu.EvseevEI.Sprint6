using System.Windows.Forms;
using Tyuiu.EvseevEI.Sprint6.Task0.V9.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        DataService ds = new();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void Condition_EEI_Enter(object sender, EventArgs e)
        {

        }

        private void Condition_EEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Result_EEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click_EEI_KeyPress_Click(object sender, EventArgs e)
        {

        }

        private void Button_Clickno_EEI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выволнил студент группы ИИПБ - 24 - 2, Евсеев Егор Игоревич");
        }

        private void ButtonResult_EEI_Click(object sender, EventArgs e)

        {
            try
            {
                textBox_Result_EEI.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(Textbox_click_EEI.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void Textbox_click_EEI_TextChanged(object sender, EventArgs e)
        //{

        //}


        private void Button_ClickA_EEI_KeyPress(object sender, KeyPressEventArgs e)

        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }

        private void Textbox_click_EEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Result_EEI_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
